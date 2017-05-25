using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Teamer.Models;

namespace TeamerMigrations
{
    [ContextType(typeof(TeamerDbContext))]
    partial class TeamerDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Teamer.Models.Dogadjaj", b =>
                {
                    b.Property<int>("DogadjajID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumDogadjaja");

                    b.Property<float>("GeoDuzina");

                    b.Property<float>("GeoSirina");

                    b.Property<string>("Opis");

                    b.Property<int?>("TimTimID");

                    b.Property<int>("TipDogadjajaID");

                    b.Key("DogadjajID");
                });

            builder.Entity("Teamer.Models.Igrac", b =>
                {
                    b.Property<int>("IgracID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika");

                    b.Property<int?>("TimTimID");

                    b.Property<string>("Username");

                    b.Key("IgracID");
                });

            builder.Entity("Teamer.Models.Izvjestaj", b =>
                {
                    b.Property<int>("IzvjestajID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DogadjajID");

                    b.Property<string>("Komentar");

                    b.Property<int>("Ocjena");

                    b.Key("IzvjestajID");
                });

            builder.Entity("Teamer.Models.Menadzer", b =>
                {
                    b.Property<int>("MenadzerID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika");

                    b.Property<string>("Username");

                    b.Key("MenadzerID");
                });

            builder.Entity("Teamer.Models.Tim", b =>
                {
                    b.Property<int>("TimID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ManagerID");

                    b.Property<string>("Naziv");

                    b.Property<byte[]>("Slika");

                    b.Property<int>("TrenerID");

                    b.Key("TimID");
                });

            builder.Entity("Teamer.Models.TipDogadjaja", b =>
                {
                    b.Property<int>("TipDogadjajaID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DogadjajID");

                    b.Property<string>("Kategorija");

                    b.Property<string>("Kod");

                    b.Property<string>("Opis");

                    b.Key("TipDogadjajaID");
                });

            builder.Entity("Teamer.Models.Trener", b =>
                {
                    b.Property<int>("TrenerID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika");

                    b.Property<string>("Username");

                    b.Key("TrenerID");
                });

            builder.Entity("Teamer.Models.Dogadjaj", b =>
                {
                    b.Reference("Teamer.Models.Tim")
                        .InverseCollection()
                        .ForeignKey("TimTimID");
                });

            builder.Entity("Teamer.Models.Igrac", b =>
                {
                    b.Reference("Teamer.Models.Tim")
                        .InverseCollection()
                        .ForeignKey("TimTimID");
                });

            builder.Entity("Teamer.Models.Izvjestaj", b =>
                {
                    b.Reference("Teamer.Models.Dogadjaj")
                        .InverseCollection()
                        .ForeignKey("DogadjajID");
                });

            builder.Entity("Teamer.Models.Tim", b =>
                {
                    b.Reference("Teamer.Models.Menadzer")
                        .InverseCollection()
                        .ForeignKey("ManagerID");

                    b.Reference("Teamer.Models.Trener")
                        .InverseReference()
                        .ForeignKey("Teamer.Models.Tim", "TrenerID");
                });

            builder.Entity("Teamer.Models.TipDogadjaja", b =>
                {
                    b.Reference("Teamer.Models.Dogadjaj")
                        .InverseReference()
                        .ForeignKey("Teamer.Models.TipDogadjaja", "DogadjajID");
                });
        }
    }
}
