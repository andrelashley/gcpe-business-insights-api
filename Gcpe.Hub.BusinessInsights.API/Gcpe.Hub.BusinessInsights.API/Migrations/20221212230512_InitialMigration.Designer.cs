﻿// <auto-generated />
using System;
using Gcpe.Hub.BusinessInsights.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gcpe.Hub.BusinessInsights.API.Migrations
{
    [DbContext(typeof(LocalDbContext))]
    [Migration("20221212230512_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Entities.NewsReleaseItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ministry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("PublishDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("ReleaseType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NewsReleaseItems");
                });

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Entities.TranslationItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ministry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("PublishDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("TranslationItems");
                });

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Entities.Url", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTimeOffset>("PublishDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("TranslationItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TranslationItemId");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Entities.Url", b =>
                {
                    b.HasOne("Gcpe.Hub.BusinessInsights.API.Entities.TranslationItem", "TranslationItem")
                        .WithMany("Urls")
                        .HasForeignKey("TranslationItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TranslationItem");
                });

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Entities.TranslationItem", b =>
                {
                    b.Navigation("Urls");
                });
#pragma warning restore 612, 618
        }
    }
}
