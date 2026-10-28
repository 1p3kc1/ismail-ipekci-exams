// Ana sayfadaki popüler ürünler.

function renderPopularProducts()
{
  const popularIds = [1, 2, 3, 5];
  const popular = products.filter(product => popularIds.includes(product.id));
  $('#popularProducts').empty();
  $.each(popular, function (index, product)
  {
    $('#popularProducts').append(createProductCard(product));
  });
}

$(function ()
{
  renderPopularProducts();
  $('#popularProducts').on('click', '.favorite-button', function ()
  {
    const id = Number($(this).data('id'));
    toggleFavorite(id);
    renderPopularProducts();
  });
});
