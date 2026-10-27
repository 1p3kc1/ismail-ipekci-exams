// Sepetteki ürünlerin tutarını ve kargo ücretini hesaplar.

function calculateTotals()
{
  const subtotal = cart.reduce(function (total, item)
  {
    const product = products.find(product => product.id === item.id);
    return total + product.price * item.quantity;
  }, 0);
  const shipping = subtotal === 0 || subtotal >= 1500 ? 0 : 79.9;
  return {
    subtotal: subtotal,
    shipping: shipping,
    total: subtotal + shipping
  };
}

function createCartItem(item)
{
  const product = products.find(product => product.id === item.id);
  const increaseDisabled = item.quantity >= 10 ? 'disabled' : '';
  return `
    <div class="d-flex gap-3 border-bottom py-3">
      <img src="assets/images/${product.image}"
           class="cart-image rounded"
           width="64"
           height="64"
           alt="${product.name}">

      <div class="flex-grow-1">
        <h3 class="h6 small fw-semibold mb-1">${product.name}</h3>
        <p class="small mb-2">${currency.format(product.price)}</p>

        <div class="d-flex justify-content-between align-items-center gap-2">
          <div class="btn-group btn-group-sm" role="group" aria-label="${product.name} adedi">
            <button class="btn btn-outline-secondary change-quantity"
                    data-id="${product.id}"
                    data-change="-1"
                    aria-label="${product.name} adedini azalt">
              −
            </button>
            <span class="btn btn-light disabled" aria-label="${item.quantity} adet">
              ${item.quantity}
            </span>
            <button class="btn btn-outline-secondary change-quantity"
                    data-id="${product.id}"
                    data-change="1"
                    aria-label="${product.name} adedini artır"
                    ${increaseDisabled}>
              +
            </button>
          </div>

          <button class="btn btn-link btn-sm text-danger p-0 remove-from-cart"
                  data-id="${product.id}"
                  aria-label="${product.name} ürününü sepetten kaldır">
            Kaldır
          </button>
        </div>
      </div>
    </div>
  `;
}

function renderCart()
{
  updateHeaderCounts();
  $('#cartSummary').toggleClass('d-none', cart.length === 0);
  if (cart.length === 0)
  {
    $('#cartItems').html(`
      <div class="text-center py-5">
        <div class="display-4 text-secondary mb-3" aria-hidden="true">🛒</div>
        <h3 class="h5">Sepetin şu an boş.</h3>
        <p class="text-secondary">Beğendiğin ürünleri sepetine ekleyebilirsin.</p>
        <a class="btn btn-primary" href="urunler.html">Ürünleri Keşfet</a>
      </div>
    `);
    return;
  }
  const items = cart.map(createCartItem).join('');
  const totals = calculateTotals();
  $('#cartItems').html(items);
  $('#subtotal').text(currency.format(totals.subtotal));
  $('#shippingAmount').text(totals.shipping === 0 ? 'Ücretsiz' : currency.format(totals.shipping));
  $('#totalAmount').text(currency.format(totals.total));
}

function createOrderItem(item)
{
  const product = products.find(product => product.id === item.id);
  const itemTotal = currency.format(product.price * item.quantity);
  return `
    <li class="list-group-item px-0 d-flex justify-content-between gap-3">
      <span>
        ${product.name}
        <span class="text-secondary">× ${item.quantity}</span>
      </span>
      <span class="text-nowrap">${itemTotal}</span>
    </li>
  `;
}

function showOrderSummary()
{
  if (cart.length === 0)
  {
    return;
  }
  const totals = calculateTotals();
  const items = cart.map(createOrderItem).join('');
  const shippingText = totals.shipping === 0 ? 'Ücretsiz' : currency.format(totals.shipping);
  $('#orderModalBody').html(`
    <div class="alert alert-info">
      Bu bir demo sipariştir. Ödeme alınmadı ve gerçek sipariş oluşturulmadı.
    </div>

    <ul class="list-group list-group-flush mb-3">${items}</ul>

    <p class="d-flex justify-content-between">
      <span>Kargo</span>
      <span>${shippingText}</span>
    </p>

    <p class="d-flex justify-content-between fw-bold fs-5 border-top pt-3">
      <span>Toplam</span>
      <span>${currency.format(totals.total)}</span>
    </p>

    <p class="small text-secondary mb-0">
      Sepetin korunur; ürün eklemeye ve projeyi denemeye devam edebilirsin.
    </p>
  `);
  const modalElement = document.getElementById('orderModal');
  bootstrap.Modal.getOrCreateInstance(modalElement).show();
}

$(function ()
{
  renderCart();
  $('#cartItems').on('click', '.change-quantity', function ()
  {
    const id = Number($(this).data('id'));
    const change = Number($(this).data('change'));
    const item = cart.find(item => item.id === id);
    if (!item)
    {
      return;
    }
    const newQuantity = item.quantity + change;
    if (newQuantity > 10)
    {
      return;
    }
    if (newQuantity <= 0)
    {
      cart = cart.filter(item => item.id !== id);
    }
    else
    {
      item.quantity = newQuantity;
    }
    saveStorage();
    renderCart();
  });
  $('#cartItems').on('click', '.remove-from-cart', function ()
  {
    const id = Number($(this).data('id'));
    cart = cart.filter(item => item.id !== id);
    saveStorage();
    renderCart();
  });
  $('#checkoutButton').on('click', showOrderSummary);
});
