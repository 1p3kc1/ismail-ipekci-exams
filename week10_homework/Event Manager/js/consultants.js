$(document).ready(function () {

    $.ajax({

        url: "data/consultants.json",

        method: "GET",

        dataType: "json",


        success: function (consultants) {


            $.each(consultants, function (index, consultant) {


                // Duruma göre CSS sınıfı belirleme

                let statusClass = "";


                if (consultant.status === "Müsait") {

                    statusClass = "status-available";

                }

                else if (consultant.status === "Görevde") {

                    statusClass = "status-busy";

                }

                else if (consultant.status === "İzinde") {

                    statusClass = "status-leave";

                }



                // Kart oluşturma

                let card = `

                    <div class="col-xl-2 col-lg-2 col-md-4 col-sm-6">

                        <div class="card consultant-card h-100">


                            <img
                                src="${consultant.image}"
                                class="consultant-image"
                                alt="${consultant.name}"
                            >


                            <div class="card-body text-center">


                                <h5 class="consultant-name">

                                    ${consultant.name}

                                </h5>


                                <p class="consultant-specialty">

                                    ${consultant.specialty}

                                </p>


                                <div class="consultant-rating">

                                    ⭐ ${consultant.rating}

                                </div>


                                <p class="consultant-experience">

                                    <strong>Tecrübe:</strong>

                                    ${consultant.experience} yıl

                                </p>


                                <span class="consultant-status ${statusClass}">

                                    ${consultant.status}

                                </span>


                            </div>

                        </div>

                    </div>

                `;


                $("#consultantList").append(card);


            });


        },


        error: function () {

            $("#consultantList").html(`

                <div class="col-12">

                    <div class="alert alert-danger text-center">

                        Danışman bilgileri yüklenemedi.

                    </div>

                </div>

            `);

        }


    });

});