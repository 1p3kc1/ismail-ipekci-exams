// ETKİNLİK FİYATLARI

const eventPrices = {
    wedding: 15000,
    conference: 12000,
    birthday: 5000,
    engagement: 8000
};


// Kişi başı ücret
const pricePerGuest = 50;


// HTML ELEMANLARINI SEÇME

const eventType = document.getElementById("eventType");

const guestCount = document.getElementById("guestCount");

const totalPrice = document.getElementById("totalPrice");

const budgetWarning = document.getElementById("budgetWarning");

const extraServices =
    document.querySelectorAll(".extra-service");

const expensiveExtras =
    document.querySelectorAll(".expensive-extra");


// FİYAT HESAPLAMA

function calculatePrice() {

    // Seçilen etkinlik türü
    const selectedEvent = eventType.value;


    // Konuk sayısı
    const guests = Number(guestCount.value) || 0;


    // Etkinliğin başlangıç fiyatı
    let total = eventPrices[selectedEvent] || 0;


    // Konuk ücretini ekle
    total = total + (guests * pricePerGuest);


    // Seçilen ek hizmetleri ekle
    extraServices.forEach(function (service) {

        if (service.checked) {

            total = total + Number(service.value);

        }

    });


    // Toplam fiyatı ekrana yaz
    totalPrice.textContent =
        total.toLocaleString("tr-TR") + " TL";


    // Pahalı hizmet kontrolü
    checkExpensiveExtras();

}


// PAHALI EK HİZMET UYARISI

function checkExpensiveExtras() {

    let expensiveSelected = false;


    expensiveExtras.forEach(function (service) {

        if (service.checked) {

            expensiveSelected = true;

        }

    });


    // Pahalı hizmet seçildiyse
    if (expensiveSelected) {

        budgetWarning.classList.remove("d-none");

        budgetWarning.textContent =
            "Dikkat! Seçtiğiniz ek hizmetler toplam fiyatı önemli ölçüde artırabilir.";

    }

    // Seçili değilse uyarıyı gizle
    else {

        budgetWarning.classList.add("d-none");

    }

}


// EVENT LISTENERS


// Etkinlik türü değiştiğinde
eventType.addEventListener("change", calculatePrice);


// Konuk sayısı değiştiğinde
guestCount.addEventListener("input", calculatePrice);


// Ek hizmetler değiştiğinde
extraServices.forEach(function (service) {

    service.addEventListener("change", calculatePrice);

});


// FORM GÖNDERME

document
    .getElementById("bookingForm")
    .addEventListener("submit", function (event) {

        // Sayfanın yenilenmesini engelle
        event.preventDefault();


        // Başarı mesajı
        alert("Rezervasyon talebiniz başarıyla oluşturuldu!");

    });