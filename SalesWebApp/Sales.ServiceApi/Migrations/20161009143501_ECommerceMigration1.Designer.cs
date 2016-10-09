using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Sales.ServiceApi.Data;

namespace Sales.ServiceApi.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    [Migration("20161009143501_ECommerceMigration1")]
    partial class ECommerceMigration1
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

                    b.Property<int>("LikesCount");

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
