// Adresteki ürün numarasına göre ürün detaylarını gösterir.

function renderProductDetail()
{
  const params = new URLSearchParams(window.location.search);
  const id = Number(params.get('id'));
  const product = products.find(product => product.id === id);
  if (!product)
  {
    document.title = 'Ürün Bulunamadı | TeknoShop';
    $('#productDetail').html(`
      <div class="alert alert-warning">
        <h1 class="h4">Ürün bulunamadı.</h1>
        <p>Bu ürün mevcut değil. Ürün listesine dönerek başka bir ürün seçebilirsin.</p>
        <a class="btn btn-primary" href="urunler.html">Ürünlere Dön</a>
      </div>
    `);
    return;
  }
  const specs = product.specs.map(function (spec)
  {
    return `<li class="mb-2">${spec}</li>`;
  }).join('');
  document.title = product.name + ' | TeknoShop';
  $('#productBreadcrumb').text(product.name);
  $('#productDetail').html(`
    <div class="row g-4 g-lg-5 align-items-center">
      <div class="col-md-6">
        <div class="border rounded-3 bg-light p-3 p-md-4">
          <img class="detail-image"
               src="assets/images/${product.image}"
               alt="${product.name}">
        </div>
      </div>

      <div class="col-md-6">
        <span class="badge text-bg-light border mb-3">
          ${product.brand} · ${product.categoryName}
        </span>

        <h1 class="h2 fw-bold mb-3">${product.name}</h1>

        <p class="small mb-3">
          <span class="text-warning" aria-hidden="true">★</span>
          ${product.rating} / 5
        </p>

        <p class="text-secondary">${product.description}</p>

        <h2 class="h6 fw-bold mt-4">Ürün Özellikleri</h2>
        <ul class="ps-3 mb-4">${specs}</ul>

        <p class="small text-secondary mb-1">Online mağaza fiyatı</p>
        <p class="fs-3 fw-bold mb-3">${currency.format(product.price)}</p>

        <div class="d-flex flex-wrap gap-2">
          <button class="btn btn-primary px-4 add-to-cart" data-id="${product.id}">
            Sepete Ekle
          </button>
          <a class="btn btn-outline-primary" href="sepet.html">Sepetime Git</a>
        </div>

        <p class="small text-secondary mt-3 mb-0">
          Örnek ürün ve özelliklerdir. Gerçek ödeme alınmaz.
        </p>
      </div>
    </div>
  `);
}

$(function ()
{
  renderProductDetail();
});
