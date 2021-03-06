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
    [Migration("20190723135040_Migrate4")]
    partial class Migrate4
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

                    b.Property<long>("ItemPrice");

                    b.Property<long>("ItemQuantity");

                    b.Property<string>("McItemId")
                        .IsRequired();

                    b.Property<string>("McItemName")
                        .IsRequired();

                    b.Property<long?>("userId");

                    b.HasKey("ItemId");

                    b.HasIndex("userId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("mcShopServer.Models.User", b =>
                {
                    b.Property<long>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("mcUserId")
                        .IsRequired();

                    b.Property<string>("mcUsername")
                        .IsRequired();

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mcShopServer.Models.Item", b =>
                {
                    b.HasOne("mcShopServer.Models.User", "User")
                        .WithMany("mcItems")
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}
