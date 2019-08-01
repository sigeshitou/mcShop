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
    [Migration("20190801084609_migartion-11-DurabilityField")]
    partial class migartion11DurabilityField
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

                    b.Property<long>("Durablity");

                    b.Property<string>("Enchantments");

                    b.Property<long>("ItemPrice");

                    b.Property<long>("ItemQuantity");

                    b.Property<string>("McItemId")
                        .IsRequired();

                    b.Property<string>("McItemName")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("ItemId");

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
                    b.HasOne("mcShopServer.Models.User", "User")
                        .WithMany("McItems")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
