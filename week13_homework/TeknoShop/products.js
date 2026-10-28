// Ürün listesi, arama, kategori filtreleri ve sıralama.
let selectedCategory = 'all';
let showFavorites = false;

function renderProducts()
{
  const query = $('#searchInput').val().trim().toLocaleLowerCase('tr-TR');
  const sort = $('#sortSelect').val();
  const filtered = products.filter(function (product)
  {
    const searchText = product.brand + ' ' + product.name + ' ' + product.categoryName;
    const matchesCategory = selectedCategory === 'all' || product.category === selectedCategory;
    const matchesSearch = searchText.toLocaleLowerCase('tr-TR').includes(query);
    const matchesFavorites = !showFavorites || favorites.includes(product.id);
    return matchesCategory && matchesSearch && matchesFavorites;
  });
  if (sort === 'priceAsc')
  {
    filtered.sort((first, second) => first.price - second.price);
  }
  else if (sort === 'priceDesc')
  {
    filtered.sort((first, second) => second.price - first.price);
  }
  else if (sort === 'name')
  {
    filtered.sort((first, second) => first.name.localeCompare(second.name, 'tr'));
  }
  $('#productList').empty();
  $.each(filtered, function (index, product)
  {
    $('#productList').append(createProductCard(product));
  });
  $('#resultCount').text(`${filtered.length} ürün gösteriliyor`);
  $('#emptyState').toggleClass('d-none', filtered.length > 0);
  $('#productsHeading').text(showFavorites ? 'Favori Ürünlerim' : 'Ürünler');
  $('#favoritesButton').toggleClass('btn-outline-secondary', !showFavorites).toggleClass('btn-danger',
    showFavorites).attr('aria-pressed', String(showFavorites));
}

function setCategory(category)
{
  selectedCategory = category;
  $('#categoryFilters button').each(function ()
  {
    const active = $(this).data('category') === category;
    $(this).toggleClass('btn-primary', active).toggleClass('btn-outline-secondary', !active).attr(
      'aria-pressed', String(active));
  });
  renderProducts();
}

$(function ()
{
  // Ana sayfadaki favori ve saat bağlantıları filtreleri adresten gönderir.
  const params = new URLSearchParams(window.location.search);
  const category = params.get('kategori');
  const validCategory = products.some(product => product.category === category);
  showFavorites = params.get('favoriler') === '1';
  setCategory(validCategory ? category : 'all');
  $('#searchInput').on('input', renderProducts);
  $('#sortSelect').on('change', renderProducts);
  $('#categoryFilters').on('click', 'button', function ()
  {
    setCategory($(this).data('category'));
  });
  $('#productList').on('click', '.favorite-button', function ()
  {
    const id = Number($(this).data('id'));
    toggleFavorite(id);
    renderProducts();
  });
  $('#favoritesButton').on('click', function ()
  {
    showFavorites = !showFavorites;
    $('#searchInput').val('');
    setCategory('all');
  });
  $('#resetFilters').on('click', function ()
  {
    showFavorites = false;
    $('#searchInput').val('');
    $('#sortSelect').val('default');
    setCategory('all');
  });
});
