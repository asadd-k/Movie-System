﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie_System.Data;

#nullable disable

namespace Movie_System.Migrations
{
    [DbContext(typeof(AppDb))]
    [Migration("20230307181112_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Movie_System.Models.Actor", b =>
                {
                    b.Property<int>("actorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("actorID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profilepicURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("actorID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Movie_System.Models.Actor_Movie", b =>
                {
                    b.Property<int>("actorID")
                        .HasColumnType("int");

                    b.Property<int>("movieID")
                        .HasColumnType("int");

                    b.HasKey("actorID", "movieID");

                    b.HasIndex("movieID");

                    b.ToTable("Actors_Movies");
                });

            modelBuilder.Entity("Movie_System.Models.Cinema", b =>
                {
                    b.Property<int>("cinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cinemaId"));

                    b.Property<int>("Description")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cinemaId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("Movie_System.Models.Movie", b =>
                {
                    b.Property<int>("movieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("movieID"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cinemaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("imageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("producerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("movieID");

                    b.HasIndex("cinemaID");

                    b.HasIndex("producerID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Movie_System.Models.Producer", b =>
                {
                    b.Property<int>("producerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("producerID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profilepicURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("producerID");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("Movie_System.Models.Actor_Movie", b =>
                {
                    b.HasOne("Movie_System.Models.Actor", "actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("actorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie_System.Models.Movie", "movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("movieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("actor");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("Movie_System.Models.Movie", b =>
                {
                    b.HasOne("Movie_System.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("cinemaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie_System.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("producerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Movie_System.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("Movie_System.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Movie_System.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("Movie_System.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
