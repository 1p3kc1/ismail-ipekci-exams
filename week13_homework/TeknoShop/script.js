// Örnek ürün verileri. Yeni ürün eklemek için bu listeye bir nesne eklemek yeterli.
const products = [
  { id: 1, name: '128 GB Akıllı Telefon', category: 'phone', categoryName: 'Telefon', price: 18999, image: 'phone.jpg', badge: '', rating: '4.8', description: 'Günlük kullanım, fotoğraf ve uygulamalar için pratik bir akıllı telefon.', specs: ['128 GB depolama', '6,1 inç ekran', 'Çift kamera', '2 yıl garanti'] },
  { id: 2, name: 'ProBook 14 Dizüstü Bilgisayar', category: 'computer', categoryName: 'Bilgisayar', price: 32999, image: 'laptop.jpg', badge: 'Popüler', rating: '4.9', description: 'Ders, iş ve günlük projelerin için hafif ve kullanışlı bir dizüstü bilgisayar.', specs: ['14 inç ekran', '16 GB RAM', '512 GB SSD', '2 yıl garanti'] },
  { id: 3, name: 'Kablosuz Kulak Üstü Kulaklık', category: 'audio', categoryName: 'Ses & Kulaklık', price: 2499, image: 'headphones.jpg', badge: '', rating: '4.7', description: 'Müzik dinlerken ve çalışırken rahatlık sağlayan kablosuz kulaklık.', specs: ['Bluetooth bağlantısı', '30 saate kadar kullanım', 'Dahili mikrofon', 'Ayarlanabilir başlık'] },
  { id: 4, name: 'Minimal Analog Kol Saati', category: 'watch', categoryName: 'Saat', price: 1299, image: 'watch.jpg', badge: 'Yeni', rating: '4.6', description: 'Sade tasarımıyla günlük kombinlerine eşlik eden analog kol saati.', specs: ['Analog gösterge', 'Ayarlanabilir kayış', '40 mm kasa', 'Hafif tasarım'] },
  { id: 5, name: 'True Wireless Bluetooth Kulaklık', category: 'audio', categoryName: 'Ses & Kulaklık', price: 1799, image: 'earbuds.jpg', badge: '', rating: '4.8', description: 'Kompakt şarj kutusuyla yanında kolayca taşıyabileceğin kablosuz kulaklık.', specs: ['Dokunmatik kontrol', 'Şarj kutusu dahil', 'Dahili mikrofon', 'USB-C şarj'] },
  { id: 6, name: 'Taşınabilir Bluetooth Hoparlör', category: 'audio', categoryName: 'Ses & Kulaklık', price: 1599, image: 'speaker.jpg', badge: '', rating: '4.5', description: 'Sevdiğin müzikleri evde veya dışarıda dinlemek için taşınabilir hoparlör.', specs: ['Kablosuz bağlantı', 'Kompakt tasarım', '10 saate kadar kullanım', 'USB şarj'] },
  { id: 7, name: 'Kablosuz Oyun Kumandası', category: 'gaming', categoryName: 'Oyun', price: 2299, image: 'gaming.jpg', badge: '', rating: '4.7', description: 'Favori oyunlarında rahat kontrol sağlayan ergonomik oyun kumandası.', specs: ['Kablosuz kullanım', 'Titreşim desteği', 'Ergonomik tutuş', 'Şarj edilebilir pil'] },
  { id: 8, name: 'RGB Mekanik Klavye', category: 'accessory', categoryName: 'Aksesuar', price: 1899, image: 'keyboard.jpg', badge: 'Yeni', rating: '4.6', description: 'Oyun ve yazı yazma deneyimini renklendiren mekanik klavye.', specs: ['RGB aydınlatma', 'Mekanik tuşlar', 'USB bağlantı', 'Kompakt tasarım'] }
];

const currency = new Intl.NumberFormat('tr-TR', { style: 'currency', currency: 'TRY' });
let cart = readStorage('teknoshop-cart', []);
let favorites = readStorage('teknoshop-favorites', []);
let selectedCategory = 'all';
let showFavorites = false;

// Kayıt bozulmuşsa sayfanın çalışmaya devam etmesini sağla.
cart = cart.filter(item => item && products.some(product => product.id === item.id) && Number.isInteger(item.quantity) && item.quantity > 0 && item.quantity <= 10);
cart = cart.filter((item, index, items) => items.findIndex(other => other.id === item.id) === index);
favorites = [...new Set(favorites.filter(id => products.some(product => product.id === id)))];

function readStorage(key, fallback) {
  try {
    const value = JSON.parse(localStorage.getItem(key));
    return Array.isArray(value) ? value : fallback;
  } catch (error) {
    return fallback;
  }
}

function saveStorage() {
  try {
    localStorage.setItem('teknoshop-cart', JSON.stringify(cart));
    localStorage.setItem('teknoshop-favorites', JSON.stringify(favorites));
  } catch (error) {
    notify('Tarayıcı kaydı kullanılamıyor. Değişikliklerin bu sayfa açıkken korunacak.');
  }
}

function notify(message) {
  $('#toastMessage').text(message);
  bootstrap.Toast.getOrCreateInstance(document.getElementById('notificationToast'), { delay: 2500 }).show();
}

function renderProducts() {
  // Sepet sayfasında ürün listesi bulunmaz.
  if (!$('#productList').length) return;
  const query = $('#searchInput').val().trim().toLocaleLowerCase('tr-TR');
  const sort = $('#sortSelect').val();
  let filtered = products.filter(product => {
    const matchesCategory = selectedCategory === 'all' || product.category === selectedCategory;
    const matchesSearch = (product.name + ' ' + product.categoryName).toLocaleLowerCase('tr-TR').includes(query);
    const matchesFavorites = !showFavorites || favorites.includes(product.id);
    return matchesCategory && matchesSearch && matchesFavorites;
  });

  if (sort === 'priceAsc') filtered.sort((a, b) => a.price - b.price);
  if (sort === 'priceDesc') filtered.sort((a, b) => b.price - a.price);
  if (sort === 'name') filtered.sort((a, b) => a.name.localeCompare(b.name, 'tr'));

  $('#productList').html(filtered.map(product => {
    const isFavorite = favorites.includes(product.id);
    const badgeColor = product.badge === 'Yeni' ? 'success' : 'primary';
    return `
      <div class="col-12 col-sm-6 col-lg-3">
        <article class="card product-card h-100 overflow-hidden">
          <div class="position-relative">
            <button class="btn w-100 p-0 border-0 rounded-0 product-detail" data-id="${product.id}" aria-label="${product.name} detaylarını göster">
              <img src="assets/images/${product.image}" class="card-img-top product-image" alt="${product.name}" loading="lazy" width="400" height="205">
            </button>
            ${product.badge ? `<span class="badge text-bg-${badgeColor} position-absolute top-0 start-0 m-3">${product.badge}</span>` : ''}
            <button class="btn btn-light border rounded-circle favorite-button position-absolute top-0 end-0 m-2 ${isFavorite ? 'text-danger' : 'text-secondary'}" data-id="${product.id}" aria-label="${product.name}: ${isFavorite ? 'favorilerden çıkar' : 'favorilere ekle'}" aria-pressed="${isFavorite}">${isFavorite ? '♥' : '♡'}</button>
          </div>
          <div class="card-body d-flex flex-column">
            <div class="d-flex justify-content-between small mb-2"><span class="text-secondary">${product.categoryName}</span><span><span class="text-warning" aria-hidden="true">★</span> ${product.rating}</span></div>
            <h3 class="h6 product-title"><button class="btn btn-link text-dark text-start text-decoration-none p-0 fw-semibold product-detail" data-id="${product.id}">${product.name}</button></h3>
            <div class="mt-auto pt-2"><div class="small text-secondary mb-1">Online mağaza fiyatı</div><div class="fs-5 fw-bold mb-3">${currency.format(product.price)}</div><button class="btn btn-primary w-100 add-to-cart" data-id="${product.id}">Sepete Ekle</button></div>
          </div>
        </article>
      </div>`;
  }).join(''));

  $('#resultCount').text(`${filtered.length} ürün gösteriliyor`);
  $('#emptyState').toggleClass('d-none', filtered.length > 0);
  $('#favoriteCount').text(favorites.length);
  $('#favoritesButton').toggleClass('btn-outline-secondary', !showFavorites).toggleClass('btn-danger', showFavorites).attr('aria-pressed', String(showFavorites));
  $('#productsHeading').text(showFavorites ? 'Favori Ürünlerim' : 'Popüler Ürünler');
}

function calculateTotals() {
  const subtotal = cart.reduce((sum, item) => sum + products.find(product => product.id === item.id).price * item.quantity, 0);
  const shipping = subtotal === 0 || subtotal >= 1500 ? 0 : 79.9;
  return { subtotal, shipping, total: subtotal + shipping };
}

function renderCart() {
  $('#cartCount').text(cart.reduce((sum, item) => sum + item.quantity, 0));
  $('#cartSummary').toggleClass('d-none', cart.length === 0);
  if (cart.length === 0) {
    $('#cartItems').html('<div class="text-center py-5"><div class="display-4 text-secondary mb-3" aria-hidden="true">🛒</div><h3 class="h5">Sepetin şu an boş.</h3><p class="text-secondary">Beğendiğin ürünleri sepetine ekleyebilirsin.</p><a class="btn btn-primary" href="index.html#urunler">Ürünleri Keşfet</a></div>');
    return;
  }

  $('#cartItems').html(cart.map(item => {
    const product = products.find(product => product.id === item.id);
    return `<div class="d-flex gap-3 border-bottom py-3">
      <img src="assets/images/${product.image}" class="cart-image rounded" width="64" height="64" alt="${product.name}">
      <div class="flex-grow-1"><h3 class="h6 small fw-semibold mb-1">${product.name}</h3><p class="small mb-2">${currency.format(product.price)}</p>
        <div class="d-flex justify-content-between align-items-center gap-2"><div class="btn-group btn-group-sm" role="group" aria-label="${product.name} adedi"><button class="btn btn-outline-secondary change-quantity" data-id="${product.id}" data-change="-1" aria-label="${product.name} adedini azalt">−</button><span class="btn btn-light disabled" aria-label="${item.quantity} adet">${item.quantity}</span><button class="btn btn-outline-secondary change-quantity" data-id="${product.id}" data-change="1" aria-label="${product.name} adedini artır" ${item.quantity >= 10 ? 'disabled' : ''}>+</button></div><button class="btn btn-link btn-sm text-danger p-0 remove-from-cart" data-id="${product.id}" aria-label="${product.name} ürününü sepetten kaldır">Kaldır</button></div>
      </div></div>`;
  }).join(''));

  const totals = calculateTotals();
  $('#subtotal').text(currency.format(totals.subtotal));
  $('#shippingAmount').text(totals.shipping === 0 ? 'Ücretsiz' : currency.format(totals.shipping));
  $('#totalAmount').text(currency.format(totals.total));
}

function addToCart(id) {
  const product = products.find(product => product.id === id);
  if (!product) return;
  const existingItem = cart.find(item => item.id === id);
  if (existingItem && existingItem.quantity >= 10) {
    notify('Bir üründen en fazla 10 adet ekleyebilirsin.');
    return;
  }
  if (existingItem) existingItem.quantity++;
  else cart.push({ id, quantity: 1 });
  saveStorage();
  renderCart();
  notify(product.name + ' sepetine eklendi.');
}

function setCategory(category) {
  selectedCategory = category;
  $('#categoryFilters button').each(function () {
    const active = $(this).data('category') === category;
    $(this).toggleClass('btn-primary', active).toggleClass('btn-outline-secondary', !active).attr('aria-pressed', String(active));
  });
  renderProducts();
}

// jQuery ile sayfa olayları.
$(function () {
  renderProducts();
  renderCart();

  $('#searchInput').on('input', renderProducts);
  $('#sortSelect').on('change', renderProducts);
  $('#categoryFilters').on('click', 'button', function () { setCategory($(this).data('category')); });

  $(document).on('click', '.add-to-cart', function () { addToCart(Number($(this).data('id'))); });

  $('#productList').on('click', '.favorite-button', function () {
    const id = Number($(this).data('id'));
    if (favorites.includes(id)) favorites = favorites.filter(favorite => favorite !== id);
    else favorites.push(id);
    saveStorage();
    renderProducts();
  });

  $('#favoritesButton').on('click', function () {
    showFavorites = !showFavorites;
    $('#searchInput').val('');
    setCategory('all');
    document.getElementById('urunler').scrollIntoView();
  });

  $('#resetFilters').on('click', function () {
    showFavorites = false;
    $('#searchInput').val('');
    $('#sortSelect').val('default');
    setCategory('all');
  });

  $('#heroWatchButton').on('click', function () {
    showFavorites = false;
    $('#searchInput').val('');
    setCategory('watch');
    document.getElementById('urunler').scrollIntoView();
  });

  $('#productList').on('click', '.product-detail', function () {
    const product = products.find(product => product.id === Number($(this).data('id')));
    $('#productModalTitle').text(product.name);
    $('#productModalBody').html(`<div class="row g-4 align-items-center"><div class="col-md-6"><img class="detail-image rounded" src="assets/images/${product.image}" alt="${product.name}"></div><div class="col-md-6"><span class="badge text-bg-light border mb-3">${product.categoryName}</span><p class="text-secondary">${product.description}</p><ul class="small ps-3 mb-4">${product.specs.map(spec => `<li class="mb-2">${spec}</li>`).join('')}</ul><p class="fs-4 fw-bold">${currency.format(product.price)}</p><button class="btn btn-primary w-100 add-to-cart" data-id="${product.id}">Sepete Ekle</button><p class="small text-secondary mt-2 mb-0">Örnek ürün ve özelliklerdir.</p></div></div>`);
    bootstrap.Modal.getOrCreateInstance(document.getElementById('productModal')).show();
  });

  $('#cartItems').on('click', '.change-quantity', function () {
    const item = cart.find(item => item.id === Number($(this).data('id')));
    const newQuantity = item.quantity + Number($(this).data('change'));
    if (newQuantity > 10) return;
    if (newQuantity <= 0) cart = cart.filter(cartItem => cartItem.id !== item.id);
    else item.quantity = newQuantity;
    saveStorage();
    renderCart();
  });

  $('#cartItems').on('click', '.remove-from-cart', function () {
    cart = cart.filter(item => item.id !== Number($(this).data('id')));
    saveStorage();
    renderCart();
  });

  $('#checkoutButton').on('click', function () {
    if (cart.length === 0) return;
    const totals = calculateTotals();
    $('#orderModalBody').html(`<div class="alert alert-info">Bu bir demo sipariştir. Ödeme alınmadı ve gerçek sipariş oluşturulmadı.</div><ul class="list-group list-group-flush mb-3">${cart.map(item => {
      const product = products.find(product => product.id === item.id);
      return `<li class="list-group-item px-0 d-flex justify-content-between gap-3"><span>${product.name} <span class="text-secondary">× ${item.quantity}</span></span><span class="text-nowrap">${currency.format(product.price * item.quantity)}</span></li>`;
    }).join('')}</ul><p class="d-flex justify-content-between"><span>Kargo</span><span>${totals.shipping ? currency.format(totals.shipping) : 'Ücretsiz'}</span></p><p class="d-flex justify-content-between fw-bold fs-5 border-top pt-3"><span>Toplam</span><span>${currency.format(totals.total)}</span></p><p class="small text-secondary mb-0">Sepetin korunur; ürün eklemeye ve projeyi denemeye devam edebilirsin.</p>`);
    bootstrap.Modal.getOrCreateInstance(document.getElementById('orderModal')).show();
  });

  // Mobil menüden bir bölüme gidildiğinde menüyü kapat.
  $('#mainMenu .nav-link').on('click', function () {
    bootstrap.Collapse.getInstance(document.getElementById('mainMenu'))?.hide();
  });
});
