﻿// <auto-generated />
using ASP_Projekt_DOTA.Date;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPProjektDOTA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230129202920_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Cart", b =>
                {
                    b.Property<int>("DecorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DecorId"));

                    b.Property<int>("DecorationId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShopDecorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DecorId");

                    b.HasIndex("DecorationId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<int>("AgilityAttributes")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForceAttributes")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IntelligenceAttributes")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Decoration", b =>
                {
                    b.Property<int>("DecorationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DecorationId"));

                    b.Property<double>("DecorationPrice")
                        .HasColumnType("float");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DecorationId");

                    b.ToTable("Decorations");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Decoration_Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("DecorationId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "DecorationId");

                    b.HasIndex("DecorationId");

                    b.ToTable("Decorations_Characters");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemCost")
                        .HasColumnType("int");

                    b.Property<string>("ItemStats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Cart", b =>
                {
                    b.HasOne("ASP_Projekt_DOTA.Models.Decoration", "Decoration")
                        .WithMany()
                        .HasForeignKey("DecorationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Decoration");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Decoration_Character", b =>
                {
                    b.HasOne("ASP_Projekt_DOTA.Models.Character", "Character")
                        .WithMany("Decorations_Characters")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_Projekt_DOTA.Models.Decoration", "Decoration")
                        .WithMany("Decorations_Characters")
                        .HasForeignKey("DecorationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Decoration");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Character", b =>
                {
                    b.Navigation("Decorations_Characters");
                });

            modelBuilder.Entity("ASP_Projekt_DOTA.Models.Decoration", b =>
                {
                    b.Navigation("Decorations_Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
