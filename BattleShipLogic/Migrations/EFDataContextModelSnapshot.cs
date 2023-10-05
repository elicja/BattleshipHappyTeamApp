﻿// <auto-generated />
using BattleShipLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace BattleShipLibrary.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class EFDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BattleShipLibrary.Models.GameDataModelDb", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GamePoints")
                        .HasColumnType("int");

                    b.Property<string>("Player1Board")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player1HitBoard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player1Points")
                        .HasColumnType("int");

                    b.Property<string>("Player2Board")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player2HitBoard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player2Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GameDataModelsDb");
                });
#pragma warning restore 612, 618
        }
    }
}
