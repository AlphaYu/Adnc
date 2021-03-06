﻿// <auto-generated />
using System;
using Adnc.Infra.EfCore.MySQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adnc.Whse.Migrations.Migrations
{
    [DbContext(typeof(AdncDbContext))]
    partial class AdncDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasCharSet("utf8mb4 ")
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Adnc.Whse.Domain.Entities.InventoryChangesLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("InventoryChangesLog");
                });

            modelBuilder.Entity("Adnc.Whse.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Describe")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Adnc.Whse.Domain.Entities.Warehouse", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<int>("BlockedQty")
                        .HasColumnType("int");

                    b.Property<long>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.HasKey("Id");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Adnc.Whse.Domain.Entities.Product", b =>
                {
                    b.OwnsOne("Adnc.Whse.Domain.Entities.ProductStatus", "Status", b1 =>
                        {
                            b1.Property<long>("ProductId")
                                .HasColumnType("bigint");

                            b1.Property<string>("ChangesReason")
                                .HasMaxLength(32)
                                .HasColumnType("varchar(32)")
                                .HasColumnName("StatusChangesReason");

                            b1.Property<int>("Code")
                                .HasColumnType("int")
                                .HasColumnName("StatusCode");

                            b1.HasKey("ProductId");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Adnc.Whse.Domain.Entities.Warehouse", b =>
                {
                    b.OwnsOne("Adnc.Whse.Domain.Entities.WarehousePosition", "Position", b1 =>
                        {
                            b1.Property<long>("WarehouseId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Code")
                                .IsRequired()
                                .HasMaxLength(32)
                                .HasColumnType("varchar(32)")
                                .HasColumnName("PositionCode");

                            b1.Property<string>("Description")
                                .HasMaxLength(64)
                                .HasColumnType("varchar(64)")
                                .HasColumnName("PositionDescription");

                            b1.HasKey("WarehouseId");

                            b1.ToTable("Warehouse");

                            b1.WithOwner()
                                .HasForeignKey("WarehouseId");
                        });

                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}
