using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RahatBookAplikacija.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gost",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: false),
                    prezime = table.Column<string>(nullable: false),
                    datumRodjenja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gost", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KontaktInfo",
                columns: table => new
                {
                    idSJ = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: false),
                    prezime = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    telefon = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KontaktInfo", x => x.idSJ);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idKorisnika = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drzava = table.Column<string>(nullable: false),
                    grad = table.Column<string>(nullable: false),
                    postanskiBroj = table.Column<string>(nullable: false),
                    adresa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Popust",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSJ = table.Column<int>(nullable: false),
                    zaRezervacijeOD = table.Column<DateTime>(nullable: false),
                    zaRezervacijeDO = table.Column<DateTime>(nullable: false),
                    pocetakObracuna = table.Column<DateTime>(nullable: false),
                    krajObracuna = table.Column<DateTime>(nullable: false),
                    procenat = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popust", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSJ = table.Column<int>(nullable: false),
                    komentar = table.Column<string>(nullable: true),
                    ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrovaniKorisnik",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idLokacije = table.Column<int>(nullable: false),
                    datumRodjenja = table.Column<DateTime>(nullable: false),
                    ime = table.Column<string>(nullable: false),
                    prezime = table.Column<string>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrovaniKorisnik", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idKorisnika = table.Column<int>(nullable: false),
                    idSJ = table.Column<int>(nullable: false),
                    dolazak = table.Column<DateTime>(nullable: false),
                    odlazak = table.Column<DateTime>(nullable: false),
                    ekskurzija = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SJSobe",
                columns: table => new
                {
                    idSJ = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idVrstaSobe = table.Column<int>(nullable: false),
                    ukupanBrojSoba = table.Column<int>(nullable: false),
                    ukupanBrojZauzetihSoba = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SJSobe", x => x.idSJ);
                });

            migrationBuilder.CreateTable(
                name: "SmjestajnaJedinica",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(nullable: false),
                    brojZvjezdica = table.Column<int>(nullable: false),
                    idLokacije = table.Column<int>(nullable: false),
                    idKarakteristike = table.Column<int>(nullable: false),
                    idUsluge = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmjestajnaJedinica", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Upit",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idOd = table.Column<int>(nullable: false),
                    idZa = table.Column<int>(nullable: false),
                    procitan = table.Column<bool>(nullable: false),
                    pitanje = table.Column<string>(nullable: false),
                    odgovor = table.Column<string>(nullable: true),
                    datumKreiranja = table.Column<DateTime>(nullable: false),
                    datumOdgovora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Uplata",
                columns: table => new
                {
                    idRezervacije = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sredstvoPlacanja = table.Column<int>(nullable: false),
                    nacinPlacanja = table.Column<int>(nullable: false),
                    brojRata = table.Column<int>(nullable: false),
                    idPopusta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplata", x => x.idRezervacije);
                });

            migrationBuilder.CreateTable(
                name: "VrstaSobe",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brojGostiju = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaSobe", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gost");

            migrationBuilder.DropTable(
                name: "KontaktInfo");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "Popust");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "RegistrovaniKorisnik");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "SJSobe");

            migrationBuilder.DropTable(
                name: "SmjestajnaJedinica");

            migrationBuilder.DropTable(
                name: "Upit");

            migrationBuilder.DropTable(
                name: "Uplata");

            migrationBuilder.DropTable(
                name: "VrstaSobe");
        }
    }
}
