// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Murad.WebApi.Data;

namespace Murad.WebApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Murad.WebApi.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Murad.WebApi.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedTime = new DateTime(2023, 2, 2, 21, 23, 40, 441, DateTimeKind.Local).AddTicks(5537),
                            ImageUrl = "https://amazoncomp.az/wp-content/uploads/2020/08/Lenovo-IdeaPad-L3-15IML05.jpg",
                            Name = "Lenovo Ideapad",
                            Price = 1750m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedTime = new DateTime(2023, 1, 3, 21, 23, 40, 441, DateTimeKind.Local).AddTicks(7200),
                            ImageUrl = "https://www.tradeinn.com/f/13796/137965389/oneplus-nord-8gb-128gb-6.44-smartphone.jpg",
                            Name = "OnePlus",
                            Price = 1450m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedTime = new DateTime(2022, 12, 12, 21, 23, 40, 441, DateTimeKind.Local).AddTicks(7216),
                            ImageUrl = "https://strgimgr.umico.az/sized/1680/258600-e3d5563b2275dac6f48948047bebb250.jpg",
                            Name = "Mibro Watch X1",
                            Price = 82m,
                            Stock = 25
                        });
                });

            modelBuilder.Entity("Murad.WebApi.Data.Product", b =>
                {
                    b.HasOne("Murad.WebApi.Data.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("Murad.WebApi.Data.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
