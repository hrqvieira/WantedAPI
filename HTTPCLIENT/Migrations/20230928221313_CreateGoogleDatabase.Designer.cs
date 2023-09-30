﻿// <auto-generated />
using HTTPCLIENT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HTTPCLIENT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230928221313_CreateGoogleDatabase")]
    partial class CreateGoogleDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HTTPCLIENT.Models.Wanted", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BirthDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Crime")
                        .HasColumnType("longtext");

                    b.Property<string>("Eyes")
                        .HasColumnType("longtext");

                    b.Property<string>("Hair")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nationality")
                        .HasColumnType("longtext");

                    b.Property<string>("ScarsAndMarks")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<string>("WantedDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("Warning_message")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Wanteds");
                });
#pragma warning restore 612, 618
        }
    }
}
