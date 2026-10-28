function calculateTotals()
{
  let subtotal = 0;
  $.each(cart, function (index, item)
  {
    const product = products.find(product => product.id === item.id);
    subtotal += product.price * item.quantity;
  });
  const shipping = subtotal === 0 || subtotal >= 1500 ? 0 : 79.9;
  return {
    subtotal: subtotal,
    shipping: shipping,
    total: subtotal + shipping
  };
}

function renderCart()
{
  $('#cartItems').empty();
  $('#cartSummary').toggleClass('d-none', cart.length === 0);
  updateHeaderCounts();
  if (cart.length === 0)
  {
    $('#cartItems').html($('#emptyCartTemplate').html());
    return;
  }
  $.each(cart, function (index, item)
  {
    const product = products.find(product => product.id === item.id);
    const row = $($('#cartItemTemplate').html());
    row.find('img').attr(
    {
      src: 'assets/images/' + product.image,
      alt: product.name
    });
    row.find('.cart-name').text(product.name);
    row.find('.cart-price').text(currency.format(product.price));
    row.find('.cart-quantity').text(item.quantity).attr('aria-label', item.quantity + ' adet');
    row.find('button').attr('data-id', item.id);
    row.find('[data-change="-1"]').attr('aria-label', product.name + ' adedini azalt');
    row.find('[data-change="1"]').prop('disabled', item.quantity >= 10)
      .attr('aria-label', product.name + ' adedini artır');
    row.find('.remove-from-cart').attr('aria-label', product.name + ' ürününü sepetten kaldır');
    $('#cartItems').append(row);
  });
  const totals = calculateTotals();
  $('#subtotal').text(currency.format(totals.subtotal));
  $('#shippingAmount').text(totals.shipping === 0 ? 'Ücretsiz' : currency.format(totals.shipping));
  $('#totalAmount').text(currency.format(totals.total));
}

$(function ()
{
  renderCart();
  $('#cartItems').on('click', '.change-quantity, .remove-from-cart', function ()
  {
    const id = Number($(this).data('id'));
    const item = cart.find(item => item.id === id);
    if ($(this).hasClass('remove-from-cart'))
    {
      item.quantity = 0;
    }
    else
    {
      item.quantity += Number($(this).data('change'));
    }
    cart = cart.filter(item => item.quantity > 0);
    saveStorage();
    renderCart();
  });
  $('#checkoutButton').on('click', function ()
  {
    const totals = calculateTotals();
    $('#orderItems').empty();
    $.each(cart, function (index, item)
    {
      const product = products.find(product => product.id === item.id);
      $('<li class="list-group-item px-0">')
        .text(product.name + ' × ' + item.quantity + ' — ' + currency.format(product.price * item.quantity))
        .appendTo('#orderItems');
    });
    $('#orderShipping').text(totals.shipping === 0 ? 'Ücretsiz' : currency.format(totals.shipping));
    $('#orderTotal').text(currency.format(totals.total));
    $('#orderModal').modal('show');
  });
});
