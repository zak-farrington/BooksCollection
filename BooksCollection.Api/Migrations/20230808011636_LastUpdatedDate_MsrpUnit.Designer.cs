﻿// <auto-generated />
using System;
using BooksCollection.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookCollection.Api.Migrations
{
    [DbContext(typeof(BooksCollectionApiContext))]
    [Migration("20230808011636_LastUpdatedDate_MsrpUnit")]
    partial class LastUpdatedDate_MsrpUnit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("BooksCollection.Api.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Isbn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Msrp")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MsrpUnit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OtherCategoryName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Uid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
