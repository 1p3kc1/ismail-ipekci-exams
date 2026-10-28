// Tüm sayfalarda kullanılan sepet, favori ve kart işlemleri.
const currency = new Intl.NumberFormat('tr-TR',
{
  style: 'currency',
  currency: 'TRY'
});
let cart = readStorage('teknoshop-cart');
let favorites = readStorage('teknoshop-favorites');
// Eski veya bozuk kayıtların sayfayı durdurmasını önler.
cart = cart.filter(item => item && products.some(product => product.id === item.id) &&
  Number.isInteger(item.quantity) && item.quantity > 0 && item.quantity <= 10);
cart = cart.filter((item, index) => cart.findIndex(other => other.id === item.id) === index);
favorites = favorites.filter((id, index) => products.some(product => product.id === id) &&
  favorites.indexOf(id) === index);

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

function updateHeaderCounts()
{
  let count = 0;
  $.each(cart, function (index, item)
  {
    count += item.quantity;
  });
  $('#cartCount').text(count);
  $('#favoriteCount').text(favorites.length);
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
    notify('Tarayıcı kaydı kullanılamıyor.');
  }
  updateHeaderCounts();
}

function notify(message)
{
  $('#toastMessage').text(message);
  bootstrap.Toast.getOrCreateInstance(document.getElementById('notificationToast')).show();
}

function toggleFavorite(id)
{
  if (favorites.includes(id))
  {
    favorites = favorites.filter(item => item !== id);
  }
  else
  {
    favorites.push(id);
  }
  saveStorage();
}

// HTML dosyasındaki boş kartı kopyalayıp ürün bilgileriyle doldurur.
function createProductCard(product)
{
  const card = $($('#productCardTemplate').html());
  const favorite = favorites.includes(product.id);
  card.find('.product-detail').attr('href', 'product.html?id=' + product.id);
  card.find('a.product-detail').first().attr('aria-label', product.name + ' detaylarını göster');
  card.find('img').attr(
  {
    src: 'assets/images/' + product.image,
    alt: product.name
  });
  card.find('.product-title a').text(product.name);
  card.find('.product-category').text(product.brand + ' · ' + product.categoryName);
  card.find('.product-rating').text(product.rating);
  card.find('.product-price').text(currency.format(product.price));
  card.find('.add-to-cart, .favorite-button').attr('data-id', product.id);
  card.find('.product-badge').text(product.badge).toggle(Boolean(product.badge))
    .addClass(product.badge === 'Yeni' ? 'text-bg-success' : 'text-bg-primary');
  card.find('.favorite-button').text(favorite ? '♥' : '♡')
    .addClass(favorite ? 'text-danger' : 'text-secondary')
    .attr('aria-pressed', String(favorite))
    .attr('aria-label', product.name + (favorite ? ': favorilerden çıkar' : ': favorilere ekle'));
  return card;
}

$(function ()
{
  updateHeaderCounts();
  $(document).on('click', '.add-to-cart', function ()
  {
    const id = Number($(this).data('id'));
    const item = cart.find(item => item.id === id);
    if (item && item.quantity >= 10)
    {
      notify('Bir üründen en fazla 10 adet ekleyebilirsin.');
      return;
    }
    if (item)
    {
      item.quantity++;
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
    notify('Ürün sepetine eklendi.');
  });
  $('#mainMenu .nav-link').on('click', function ()
  {
    $('#mainMenu').collapse('hide');
  });
});
