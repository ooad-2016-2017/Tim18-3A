using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace TeamerMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Menadzer",
                columns: table => new
                {
                    MenadzerID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "BLOB", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menadzer", x => x.MenadzerID);
                });
            migration.CreateTable(
                name: "TipDogadjaja",
                columns: table => new
                {
                    TipDogadjajaID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Kategorija = table.Column(type: "TEXT", nullable: true),
                    Kod = table.Column(type: "TEXT", nullable: true),
                    Opis = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipDogadjaja", x => x.TipDogadjajaID);
                });
            migration.CreateTable(
                name: "Tim",
                columns: table => new
                {
                    TimID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    ManagerID = table.Column(type: "INTEGER", nullable: false),
                    Naziv = table.Column(type: "TEXT", nullable: false),
                    Slika = table.Column(type: "BLOB", nullable: true),
                    TrenerID = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tim", x => x.TimID);
                    table.ForeignKey(
                        name: "FK_Tim_Menadzer_ManagerID",
                        columns: x => x.ManagerID,
                        referencedTable: "Menadzer",
                        referencedColumn: "MenadzerID");
                });
            migration.CreateTable(
                name: "Dogadjaj",
                columns: table => new
                {
                    DogadjajID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumDogadjaja = table.Column(type: "TEXT", nullable: false),
                    GeoDuzina = table.Column(type: "REAL", nullable: false),
                    GeoSirina = table.Column(type: "REAL", nullable: false),
                    Opis = table.Column(type: "TEXT", nullable: true),
                    TimTimID = table.Column(type: "INTEGER", nullable: true),
                    TipDogadjajaID = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogadjaj", x => x.DogadjajID);
                    table.ForeignKey(
                        name: "FK_Dogadjaj_Tim_TimTimID",
                        columns: x => x.TimTimID,
                        referencedTable: "Tim",
                        referencedColumn: "TimID");
                    table.ForeignKey(
                        name: "FK_Dogadjaj_TipDogadjaja_TipDogadjajaID",
                        columns: x => x.TipDogadjajaID,
                        referencedTable: "TipDogadjaja",
                        referencedColumn: "TipDogadjajaID");
                });
            migration.CreateTable(
                name: "Igrac",
                columns: table => new
                {
                    IgracID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "BLOB", nullable: true),
                    TimID = table.Column(type: "INTEGER", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igrac", x => x.IgracID);
                    table.ForeignKey(
                        name: "FK_Igrac_Tim_TimID",
                        columns: x => x.TimID,
                        referencedTable: "Tim",
                        referencedColumn: "TimID");
                });
            migration.CreateTable(
                name: "Trener",
                columns: table => new
                {
                    TrenerID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "BLOB", nullable: true),
                    TimID = table.Column(type: "INTEGER", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trener", x => x.TrenerID);
                    table.ForeignKey(
                        name: "FK_Trener_Tim_TimID",
                        columns: x => x.TimID,
                        referencedTable: "Tim",
                        referencedColumn: "TimID");
                });
            migration.CreateTable(
                name: "Izvjestaj",
                columns: table => new
                {
                    IzvjestajID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DogadjajID = table.Column(type: "INTEGER", nullable: false),
                    Komentar = table.Column(type: "TEXT", nullable: true),
                    Ocjena = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaj", x => x.IzvjestajID);
                    table.ForeignKey(
                        name: "FK_Izvjestaj_Dogadjaj_DogadjajID",
                        columns: x => x.DogadjajID,
                        referencedTable: "Dogadjaj",
                        referencedColumn: "DogadjajID");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Igrac");
            migration.DropTable("Izvjestaj");
            migration.DropTable("Trener");
            migration.DropTable("Dogadjaj");
            migration.DropTable("Tim");
            migration.DropTable("TipDogadjaja");
            migration.DropTable("Menadzer");
        }
    }
}
