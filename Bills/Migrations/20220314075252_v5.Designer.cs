﻿// <auto-generated />
using System;
using Bills.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bills.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220314075252_v5")]
    partial class v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bills.Models.Entities.Bill", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("BillsTotal")
                        .HasColumnType("real");

                    b.Property<int>("ClintId")
                        .HasColumnType("int");

                    b.Property<float>("PaidUp")
                        .HasColumnType("real");

                    b.Property<float>("PercentageDiscount")
                        .HasColumnType("real");

                    b.Property<float>("TheNet")
                        .HasColumnType("real");

                    b.Property<float>("TheRest")
                        .HasColumnType("real");

                    b.Property<float>("ValueDiscount")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClintId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Bills.Models.Entities.BillItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int");

                    b.Property<int>("TotalBalance")
                        .HasColumnType("int");

                    b.Property<int>("billId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("billId");

                    b.ToTable("BillItems");
                });

            modelBuilder.Entity("Bills.Models.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Bills.Models.Entities.CompanyData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CompanyDatas");
                });

            modelBuilder.Entity("Bills.Models.Entities.CompanyType", b =>
                {
                    b.Property<int>("CompanyDataId")
                        .HasColumnType("int");

                    b.Property<int>("TypeDataId")
                        .HasColumnType("int");

                    b.HasKey("CompanyDataId", "TypeDataId");

                    b.HasIndex("TypeDataId");

                    b.ToTable("CompanyTypes");
                });

            modelBuilder.Entity("Bills.Models.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BalanceOfTheFirstDuration")
                        .HasColumnType("int");

                    b.Property<int>("BuyingPrice")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityRest")
                        .HasColumnType("int");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int");

                    b.Property<int>("typeId")
                        .HasColumnType("int");

                    b.Property<int>("unitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("typeId");

                    b.HasIndex("unitId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Bills.Models.Entities.TypeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeDatas");
                });

            modelBuilder.Entity("Bills.Models.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Bills.Models.Entities.Bill", b =>
                {
                    b.HasOne("Bills.Models.Entities.Client", "client")
                        .WithMany()
                        .HasForeignKey("ClintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("Bills.Models.Entities.BillItem", b =>
                {
                    b.HasOne("Bills.Models.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bills.Models.Entities.Bill", "bill")
                        .WithMany("BillItems")
                        .HasForeignKey("billId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bill");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Bills.Models.Entities.CompanyType", b =>
                {
                    b.HasOne("Bills.Models.Entities.CompanyData", "CompanyData")
                        .WithMany("CompanyTypes")
                        .HasForeignKey("CompanyDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bills.Models.Entities.TypeData", "TypeData")
                        .WithMany("CompanyTypes")
                        .HasForeignKey("TypeDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyData");

                    b.Navigation("TypeData");
                });

            modelBuilder.Entity("Bills.Models.Entities.Item", b =>
                {
                    b.HasOne("Bills.Models.Entities.CompanyData", "CompanyData")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bills.Models.Entities.TypeData", "TypeData")
                        .WithMany()
                        .HasForeignKey("typeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bills.Models.Entities.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("unitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyData");

                    b.Navigation("TypeData");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Bills.Models.Entities.Bill", b =>
                {
                    b.Navigation("BillItems");
                });

            modelBuilder.Entity("Bills.Models.Entities.CompanyData", b =>
                {
                    b.Navigation("CompanyTypes");
                });

            modelBuilder.Entity("Bills.Models.Entities.TypeData", b =>
                {
                    b.Navigation("CompanyTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
