﻿// <auto-generated />
using System;
using Gcpe.Hub.BusinessInsights.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gcpe.Hub.BusinessInsights.API.Migrations
{
    [DbContext(typeof(LocalBusinessInsightsDbContext))]
    partial class LocalBusinessInsightsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Entities.NewsReleaseItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Headline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ministry")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("PublishDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReleaseType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("NewsReleaseItems");
                });

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Models.Url", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Href")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NewsReleaseItemId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("PublishDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NewsReleaseItemId");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Models.Url", b =>
                {
                    b.HasOne("Gcpe.Hub.BusinessInsights.API.Entities.NewsReleaseItem", null)
                        .WithMany("Urls")
                        .HasForeignKey("NewsReleaseItemId");
                });

            modelBuilder.Entity("Gcpe.Hub.BusinessInsights.API.Entities.NewsReleaseItem", b =>
                {
                    b.Navigation("Urls");
                });
#pragma warning restore 612, 618
        }
    }
}
