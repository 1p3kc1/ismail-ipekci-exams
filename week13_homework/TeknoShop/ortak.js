// Tüm sayfalarda kullanılan para birimi, tarayıcı kayıtları ve ürün kartları.
const currency = new Intl.NumberFormat('tr-TR',
{
  style: 'currency',
  currency: 'TRY'
});
let cart = readStorage('teknoshop-cart');
let favorites = readStorage('teknoshop-favorites');

// Tarayıcıda eski veya bozuk kayıt varsa geçerli ürünleri koru.
cart = cart.filter(function (item)
{
  return item && products.some(product => product.id === item.id) && Number.isInteger(item.quantity) &&
    item.quantity > 0 && item.quantity <= 10;
});
cart = cart.filter(function (item, index, items)
{
  return items.findIndex(other => other.id === item.id) === index;
});
favorites = favorites.filter(id => products.some(product => product.id === id));
favorites = [...new Set(favorites)];

function readStorage(key)
{
  try
  {
    const value = JSON.parse(localStorage.getItem(key));
    return Array.isArray(value) ? value : [];
  }
  catch (error)
  {
    return [];
  }
}

function saveStorage()
{
  try
  {
    localStorage.setItem('teknoshop-cart', JSON.stringify(cart));
    localStorage.setItem('teknoshop-favorites', JSON.stringify(favorites));
  }
  catch (error)
  {
    notify('Tarayıcı kaydı kullanılamıyor. Değişikliklerin bu sayfa açıkken korunacak.');
  }
}

function notify(message)
{
  const toastElement = document.getElementById('notificationToast');
  $('#toastMessage').text(message);
  bootstrap.Toast.getOrCreateInstance(toastElement,
  {
    delay: 2500
  }).show();
}

function updateHeaderCounts()
{
  const itemCount = cart.reduce((total, item) => total + item.quantity, 0);
  $('#cartCount').text(itemCount);
  $('#favoriteCount').text(favorites.length);
}

function addToCart(id)
{
  const product = products.find(product => product.id === id);
  if (!product)
  {
    return;
  }
  const existingItem = cart.find(item => item.id === id);
  if (existingItem && existingItem.quantity >= 10)
  {
    notify('Bir üründen en fazla 10 adet ekleyebilirsin.');
    return;
  }
  if (existingItem)
  {
    existingItem.quantity++;
  }
  else
  {
    cart.push(
    {
      id: id,
      quantity: 1
    });
  }
  saveStorage();
  updateHeaderCounts();
  notify(product.name + ' sepetine eklendi.');
}

function toggleFavorite(id)
{
  if (favorites.includes(id))
  {
    favorites = favorites.filter(favorite => favorite !== id);
  }
  else
  {
    favorites.push(id);
  }
  saveStorage();
  updateHeaderCounts();
}

// Ana sayfa ve ürünler sayfası aynı kart görünümünü kullanır.

function createProductCard(product)
{
  const isFavorite = favorites.includes(product.id);
  const badgeColor = product.badge === 'Yeni' ? 'success' : 'primary';
  const favoriteColor = isFavorite ? 'text-danger' : 'text-secondary';
  const favoriteLabel = isFavorite ? 'favorilerden çıkar' : 'favorilere ekle';
  const favoriteSymbol = isFavorite ? '♥' : '♡';
  let badge = '';
  if (product.badge)
  {
    badge = `
      <span class="badge text-bg-${badgeColor} position-absolute top-0 start-0 m-3">
        ${product.badge}
      </span>
    `;
  }
  return `
    <div class="col-12 col-sm-6 col-lg-3">
      <article class="card product-card h-100 overflow-hidden">
        <div class="position-relative">
          <a class="d-block w-100 product-detail"
             href="urun.html?id=${product.id}"
             aria-label="${product.name} detaylarını göster">
            <img src="assets/images/${product.image}"
                 class="card-img-top product-image"
                 alt="${product.name}"
                 loading="lazy"
                 width="400"
                 height="205">
          </a>

          ${badge}

          <button class="btn btn-light border rounded-circle favorite-button position-absolute top-0 end-0 m-2 ${favoriteColor}"
                  data-id="${product.id}"
                  aria-label="${product.name}: ${favoriteLabel}"
                  aria-pressed="${isFavorite}">
            ${favoriteSymbol}
          </button>
        </div>

        <div class="card-body d-flex flex-column">
          <div class="d-flex justify-content-between small mb-2">
            <span class="text-secondary">${product.brand} · ${product.categoryName}</span>
            <span>
              <span class="text-warning" aria-hidden="true">★</span>
              ${product.rating}
            </span>
          </div>

          <h3 class="h6 product-title">
            <a class="text-dark text-decoration-none fw-semibold product-detail"
               href="urun.html?id=${product.id}">
              ${product.name}
            </a>
          </h3>

          <div class="mt-auto pt-2">
            <div class="small text-secondary mb-1">Online mağaza fiyatı</div>
            <div class="fs-5 fw-bold mb-3">${currency.format(product.price)}</div>
            <button class="btn btn-primary w-100 add-to-cart" data-id="${product.id}">
              Sepete Ekle
            </button>
          </div>
        </div>
      </article>
    </div>
  `;
}

$(function ()
{
  updateHeaderCounts();
  $(document).on('click', '.add-to-cart', function ()
  {
    const id = Number($(this).data('id'));
    addToCart(id);
  });
  $('#mainMenu .nav-link').on('click', function ()
  {
    const menuElement = document.getElementById('mainMenu');
    const menu = bootstrap.Collapse.getInstance(menuElement);
    if (menu)
    {
      menu.hide();
    }
  });
});
