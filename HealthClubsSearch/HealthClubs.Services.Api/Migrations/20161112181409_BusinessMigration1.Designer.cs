using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HealthClubs.Services.Api.DAL;

namespace HealthClubs.Services.Api.Migrations
{
    [DbContext(typeof(BusinessDbContext))]
    [Migration("20161112181409_BusinessMigration1")]
    partial class BusinessMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthClubs.Data.Core.Models.Business", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("BusinessName");

                    b.Property<string>("BusinessType");

                    b.Property<string>("Link");

                    b.Property<decimal>("Rating");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });
        }
    }
}
