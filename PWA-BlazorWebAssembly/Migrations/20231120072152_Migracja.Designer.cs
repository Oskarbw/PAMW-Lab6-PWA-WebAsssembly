﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PWA_BlazorWebAssembly.DataAccess;

#nullable disable

namespace PWA_BlazorWebAssembly.Migrations
{
    [DbContext(typeof(PostOfficeContext))]
    [Migration("20231120072152_Migracja")]
    partial class Migracja
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("PAMW5_MVC.Models.Parcel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Receiver")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Parcels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Receiver = "Frank",
                            Sender = "John",
                            Weight = 12
                        },
                        new
                        {
                            Id = 2,
                            Receiver = "Hilary",
                            Sender = "Janice",
                            Weight = 17
                        });
                });
#pragma warning restore 612, 618
        }
    }
}