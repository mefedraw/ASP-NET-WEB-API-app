﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TgAppCrates.DataAccess;

#nullable disable

namespace TgAppCrates.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class CardsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TgAppCrates.Core.models.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("TgId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("Type")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("TgAppCrates.Core.models.CardData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("Type")
                        .HasColumnType("smallint");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CardsData");
                });

            modelBuilder.Entity("TgAppCrates.Core.models.TradeCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("OwnerTgId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(20,0)");

                    b.Property<short>("Type")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("TradeMarket");
                });

            modelBuilder.Entity("TgAppCrates.Core.models.UserFunds", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Funds")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("TgId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserFunds");
                });
#pragma warning restore 612, 618
        }
    }
}
