using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RaiseYourHand.Models;

namespace aspnetcoreapp.Migrations
{
    [DbContext(typeof(HandDbContext))]
    [Migration("20161225090548_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RaiseYourHand.Models.Hand", b =>
                {
                    b.Property<int>("HandNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<string>("UserName");

                    b.HasKey("HandNo");

                    b.ToTable("Hands");
                });
        }
    }
}
