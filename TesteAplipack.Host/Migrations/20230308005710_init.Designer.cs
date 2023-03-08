﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteAplipack.Host.Context;

#nullable disable

namespace TesteAplipack.Host.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20230308005710_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("TesteAplipack.Domain.Box.Models.BoxModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PalletId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Valid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Boxes");
                });
#pragma warning restore 612, 618
        }
    }
}
