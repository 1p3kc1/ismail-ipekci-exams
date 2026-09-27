using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_TravelGuide.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    EntryFee = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "EntryFee", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul", 1400, "Topkapı Sarayı" },
                    { 2, "Ankara", 0, "Anıtkabir" },
                    { 3, "İzmir", 900, "Efes Antik Kenti" },
                    { 4, "Denizli", 700, "Pamukkale Travertenleri" },
                    { 5, "Nevşehir", 600, "Göreme Açık Hava Müzesi" },
                    { 6, "Trabzon", 500, "Sümela Manastırı" },
                    { 7, "Konya", 0, "Mevlana Müzesi" },
                    { 8, "Karabük", 0, "Safranbolu Evleri" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
