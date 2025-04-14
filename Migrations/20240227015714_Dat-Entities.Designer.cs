﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RomRepo.api;

#nullable disable

namespace RomRepo.api.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20240227015714_Dat-Entities")]
    partial class DatEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("RomRepo.api.Models.ApiKey", b =>
                {
                    b.Property<int>("ApiKeyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("IPAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstallationID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ApiKeyID");

                    b.ToTable("ApiKey");
                });

            modelBuilder.Entity("RomRepo.api.Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GameSystemID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("NoIntroGameID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NoIntroGameSystemID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentGameID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentNoIntroID")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameID");

                    b.HasIndex("GameSystemID");

                    b.HasIndex("ParentGameID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameSystem", b =>
                {
                    b.Property<int>("GameSystemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Homepage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NoIntroGameSystemID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("GameSystemID");

                    b.ToTable("GameSystem");
                });

            modelBuilder.Entity("RomRepo.api.Models.Rom", b =>
                {
                    b.Property<int>("RomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CRC")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MD5")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("NoIntroGameID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SHA1")
                        .HasColumnType("TEXT");

                    b.Property<string>("SHA256")
                        .HasColumnType("TEXT");

                    b.Property<string>("Serial")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("RomID");

                    b.HasIndex("GameID");

                    b.ToTable("Rom");
                });

            modelBuilder.Entity("RomRepo.api.Models.Game", b =>
                {
                    b.HasOne("RomRepo.api.Models.GameSystem", "GameSystem")
                        .WithMany("Games")
                        .HasForeignKey("GameSystemID");

                    b.HasOne("RomRepo.api.Models.Game", "ParentGame")
                        .WithMany()
                        .HasForeignKey("ParentGameID");

                    b.Navigation("GameSystem");

                    b.Navigation("ParentGame");
                });

            modelBuilder.Entity("RomRepo.api.Models.Rom", b =>
                {
                    b.HasOne("RomRepo.api.Models.Game", "Game")
                        .WithMany("Roms")
                        .HasForeignKey("GameID");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("RomRepo.api.Models.Game", b =>
                {
                    b.Navigation("Roms");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameSystem", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
