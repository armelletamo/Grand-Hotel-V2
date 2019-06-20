﻿// <auto-generated />
using System;
using GrandHotel.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrandHotel.Core.Migrations
{
    [DbContext(typeof(GrandHotelContext))]
    [Migration("20190617130308_roletable")]
    partial class roletable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GrandHotel.Core.Models.Adresse", b =>
                {
                    b.Property<int>("IdClient");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Complement")
                        .HasMaxLength(40);

                    b.Property<string>("Rue")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("IdClient");

                    b.ToTable("Adresse");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Calendrier", b =>
                {
                    b.Property<DateTime>("Jour")
                        .HasColumnType("date");

                    b.HasKey("Jour");

                    b.ToTable("Calendrier");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Chambre", b =>
                {
                    b.Property<short>("Numero");

                    b.Property<bool>("Bain");

                    b.Property<bool?>("Douche")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<byte>("Etage");

                    b.Property<byte>("NbLits");

                    b.Property<short?>("NumTel");

                    b.Property<bool?>("Wc")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("WC")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Numero");

                    b.ToTable("Chambre");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CarteFidelite");

                    b.Property<string>("Civilite")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Societe")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeModePaiement")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateFacture")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DatePaiement")
                        .HasColumnType("date");

                    b.Property<int>("IdClient");

                    b.HasKey("Id");

                    b.HasIndex("CodeModePaiement");

                    b.HasIndex("IdClient");

                    b.ToTable("Facture");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.LigneFacture", b =>
                {
                    b.Property<int>("IdFacture");

                    b.Property<int>("NumLigne");

                    b.Property<decimal>("MontantHt")
                        .HasColumnName("MontantHT")
                        .HasColumnType("decimal(12, 3)");

                    b.Property<short>("Quantite")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("TauxReduction")
                        .HasColumnType("decimal(6, 3)");

                    b.Property<decimal>("TauxTva")
                        .HasColumnName("TauxTVA")
                        .HasColumnType("decimal(6, 3)");

                    b.HasKey("IdFacture", "NumLigne");

                    b.ToTable("LigneFacture");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.ModePaiement", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Code");

                    b.ToTable("ModePaiement");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Reservation", b =>
                {
                    b.Property<short>("NumChambre");

                    b.Property<DateTime>("Jour")
                        .HasColumnType("date");

                    b.Property<byte>("HeureArrivee")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((17))");

                    b.Property<int>("IdClient");

                    b.Property<byte>("NbPersonnes");

                    b.Property<bool?>("Travail");

                    b.HasKey("NumChambre", "Jour");

                    b.HasIndex("IdClient")
                        .HasName("IDX_ReservationClient_FK");

                    b.HasIndex("Jour");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Tarif", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("date");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(12, 3)");

                    b.HasKey("Code");

                    b.ToTable("Tarif");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.TarifChambre", b =>
                {
                    b.Property<short>("NumChambre");

                    b.Property<string>("CodeTarif")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("NumChambre", "CodeTarif");

                    b.HasIndex("CodeTarif");

                    b.ToTable("TarifChambre");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Telephone", b =>
                {
                    b.Property<string>("Numero")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("CodeType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("IdClient");

                    b.Property<bool>("Pro");

                    b.HasKey("Numero");

                    b.HasIndex("IdClient");

                    b.ToTable("Telephone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Adresse", b =>
                {
                    b.HasOne("GrandHotel.Core.Models.Client", "IdClientNavigation")
                        .WithOne("Adresse")
                        .HasForeignKey("GrandHotel.Core.Models.Adresse", "IdClient")
                        .HasConstraintName("FK_Adresse_Client");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Facture", b =>
                {
                    b.HasOne("GrandHotel.Core.Models.ModePaiement", "CodeModePaiementNavigation")
                        .WithMany("Facture")
                        .HasForeignKey("CodeModePaiement")
                        .HasConstraintName("FK_Facture_Paiement");

                    b.HasOne("GrandHotel.Core.Models.Client", "IdClientNavigation")
                        .WithMany("Facture")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_Facture_Client");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.LigneFacture", b =>
                {
                    b.HasOne("GrandHotel.Core.Models.Facture", "IdFactureNavigation")
                        .WithMany("LigneFacture")
                        .HasForeignKey("IdFacture")
                        .HasConstraintName("FK_LigneFacture_Facture");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Reservation", b =>
                {
                    b.HasOne("GrandHotel.Core.Models.Client", "IdClientNavigation")
                        .WithMany("Reservation")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_Reservation_Client");

                    b.HasOne("GrandHotel.Core.Models.Calendrier", "JourNavigation")
                        .WithMany("Reservation")
                        .HasForeignKey("Jour")
                        .HasConstraintName("FK_Reservation_Calendrier");

                    b.HasOne("GrandHotel.Core.Models.Chambre", "NumChambreNavigation")
                        .WithMany("Reservation")
                        .HasForeignKey("NumChambre")
                        .HasConstraintName("FK_Reservation_Chambre");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.TarifChambre", b =>
                {
                    b.HasOne("GrandHotel.Core.Models.Tarif", "CodeTarifNavigation")
                        .WithMany("TarifChambre")
                        .HasForeignKey("CodeTarif")
                        .HasConstraintName("FK_TarifChambre_Tarif");

                    b.HasOne("GrandHotel.Core.Models.Chambre", "NumChambreNavigation")
                        .WithMany("TarifChambre")
                        .HasForeignKey("NumChambre")
                        .HasConstraintName("FK_TarifChambre_Chambre");
                });

            modelBuilder.Entity("GrandHotel.Core.Models.Telephone", b =>
                {
                    b.HasOne("GrandHotel.Core.Models.Client", "IdClientNavigation")
                        .WithMany("Telephone")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_Telephone_Client");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
