// Ürün numarası adresten alınır: product.html?id=1
$(function ()
{
  const id = Number(new URLSearchParams(window.location.search).get('id'));
  const product = products.find(product => product.id === id);
  if (!product)
  {
    document.title = 'Ürün Bulunamadı | TeknoShop';
    $('#missingProduct').removeClass('d-none');
    return;
  }
  document.title = product.name + ' | TeknoShop';
  $('#productDetail').removeClass('d-none');
  $('#productBreadcrumb, #detailName').text(product.name);
  $('#detailImage').attr(
  {
    src: 'assets/images/' + product.image,
    alt: product.name
  });
  $('#detailCategory').text(product.brand + ' · ' + product.categoryName);
  $('#detailRating').text(product.rating);
  $('#detailDescription').text(product.description);
  $('#detailPrice').text(currency.format(product.price));
  $('#detailAddButton').attr('data-id', product.id);
  $.each(product.specs, function (index, spec)
  {
    $('#detailSpecs').append($('<li class="mb-2">').text(spec));
  });
});
