﻿// <auto-generated />
using System;
using ExamenDAW.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamenDAW.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240125130807_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamenDAW.Models.Asociativa.Asociativa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("asociativas");
                });

            modelBuilder.Entity("ExamenDAW.Models.Eveniment.Eveniment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AsociativaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AsociativaId");

                    b.HasIndex("Nume")
                        .IsUnique();

                    b.ToTable("eveniments");
                });

            modelBuilder.Entity("ExamenDAW.Models.Participant.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AsociativaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AsociativaId");

                    b.ToTable("participants");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Participant");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ExamenDAW.Models.Organizator.Organizator", b =>
                {
                    b.HasBaseType("ExamenDAW.Models.Participant.Participant");

                    b.Property<string>("Experienta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Organizator");
                });

            modelBuilder.Entity("ExamenDAW.Models.Spectator.Spectator", b =>
                {
                    b.HasBaseType("ExamenDAW.Models.Participant.Participant");

                    b.Property<long>("Numar")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("Spectator");
                });

            modelBuilder.Entity("ExamenDAW.Models.Eveniment.Eveniment", b =>
                {
                    b.HasOne("ExamenDAW.Models.Asociativa.Asociativa", "Asociativa")
                        .WithMany("Eveniments")
                        .HasForeignKey("AsociativaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asociativa");
                });

            modelBuilder.Entity("ExamenDAW.Models.Participant.Participant", b =>
                {
                    b.HasOne("ExamenDAW.Models.Asociativa.Asociativa", "Asociativa")
                        .WithMany("Participants")
                        .HasForeignKey("AsociativaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asociativa");
                });

            modelBuilder.Entity("ExamenDAW.Models.Asociativa.Asociativa", b =>
                {
                    b.Navigation("Eveniments");

                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}