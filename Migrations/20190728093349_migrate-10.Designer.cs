﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using mcShopServer.Context;

namespace mcShopServer.Migrations
{
    [DbContext(typeof(ShoppingContext))]
    [Migration("20190728093349_migrate-10")]
    partial class migrate10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("mcShopServer.Models.Item", b =>
                {
                    b.Property<long>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<string>("Enchantments");

                    b.Property<long?>("ItemPriceItemId");

                    b.Property<long>("ItemQuantity");

                    b.Property<string>("McItemId")
                        .IsRequired();

                    b.Property<string>("McItemName")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("ItemId");

                    b.HasIndex("ItemPriceItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("mcShopServer.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("McUserId")
                        .IsRequired();

                    b.Property<string>("McUsername")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mcShopServer.Models.Item", b =>
                {
                    b.HasOne("mcShopServer.Models.Item", "ItemPrice")
                        .WithMany()
                        .HasForeignKey("ItemPriceItemId");

                    b.HasOne("mcShopServer.Models.User", "User")
                        .WithMany("McItems")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
