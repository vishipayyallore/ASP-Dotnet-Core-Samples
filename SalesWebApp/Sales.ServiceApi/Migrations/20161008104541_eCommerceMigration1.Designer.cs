using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Sales.ServiceApi.Data;

namespace Sales.ServiceApi.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    [Migration("20161008104541_eCommerceMigration1")]
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

                    b.Property<int>("PurchaseByCount");

                    b.Property<decimal>("Rating");

                    b.Property<string>("Tags");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
        }
    }
}
