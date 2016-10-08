using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Sales.ServiceApi.Data;

namespace Sales.ServiceApi.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    [Migration("20161008094846_eCommerceMigration1")]
    partial class eCommerceMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sales.Data.Core.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<Guid?>("ProductsViewModelId");

                    b.Property<int>("PurchaseByCount");

                    b.Property<decimal>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("ProductsViewModelId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Sales.Data.Core.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Sales.ServiceApi.Data.ViewModels.ProductsViewModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("ProductsListViewModels");
                });

            modelBuilder.Entity("Sales.Data.Core.Models.Product", b =>
                {
                    b.HasOne("Sales.ServiceApi.Data.ViewModels.ProductsViewModel")
                        .WithMany("Products")
                        .HasForeignKey("ProductsViewModelId");
                });

            modelBuilder.Entity("Sales.Data.Core.Models.Tag", b =>
                {
                    b.HasOne("Sales.Data.Core.Models.Product")
                        .WithMany("Tags")
                        .HasForeignKey("ProductId");
                });
        }
    }
}
