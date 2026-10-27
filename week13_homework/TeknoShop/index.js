// Ana sayfadaki popüler ürünler.

function renderPopularProducts()
{
  const popularIds = [1, 2, 3, 5];
  const popular = products.filter(product => popularIds.includes(product.id));
  const cards = popular.map(createProductCard).join('');
  $('#popularProducts').html(cards);
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
