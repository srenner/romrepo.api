﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RomRepo.api;

#nullable disable

namespace RomRepo.api.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

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

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

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

                    b.Property<string>("NoIntroGameID")
                        .HasColumnType("TEXT");

                    b.Property<string>("NoIntroGameSystemID")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentGameID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParentNoIntroID")
                        .HasColumnType("TEXT");

                    b.HasKey("GameID");

                    b.HasIndex("GameSystemID");

                    b.HasIndex("ParentGameID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameAttribute", b =>
                {
                    b.Property<int>("GameAttributeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GameAttributeID");

                    b.HasIndex("GameID");

                    b.ToTable("GameAttribute");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameFavorite", b =>
                {
                    b.Property<int>("GameFavoriteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApiKeyID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameFavoriteID");

                    b.HasIndex("ApiKeyID");

                    b.HasIndex("GameID");

                    b.ToTable("GameFavorite");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameInstallation", b =>
                {
                    b.Property<int>("GameInstallationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApiKeyID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameInstallationID");

                    b.HasIndex("ApiKeyID");

                    b.HasIndex("GameID");

                    b.ToTable("GameInstallation");
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

                    b.Property<string>("NoIntroGameSystemID")
                        .HasColumnType("TEXT");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("GameSystemID");

                    b.ToTable("GameSystem");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameSystemFavorite", b =>
                {
                    b.Property<int>("GameSystemFavoriteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApiKeyID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameSystemID")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameSystemFavoriteID");

                    b.HasIndex("ApiKeyID");

                    b.HasIndex("GameSystemID");

                    b.ToTable("GameSystemFavorite");
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

                    b.Property<string>("NoIntroGameID")
                        .HasColumnType("TEXT");

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

            modelBuilder.Entity("RomRepo.api.Models.GameAttribute", b =>
                {
                    b.HasOne("RomRepo.api.Models.Game", "Game")
                        .WithMany("Attributes")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameFavorite", b =>
                {
                    b.HasOne("RomRepo.api.Models.ApiKey", "ApiKey")
                        .WithMany()
                        .HasForeignKey("ApiKeyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RomRepo.api.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameInstallation", b =>
                {
                    b.HasOne("RomRepo.api.Models.ApiKey", "ApiKey")
                        .WithMany()
                        .HasForeignKey("ApiKeyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RomRepo.api.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("RomRepo.api.Models.GameSystemFavorite", b =>
                {
                    b.HasOne("RomRepo.api.Models.ApiKey", "ApiKey")
                        .WithMany()
                        .HasForeignKey("ApiKeyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RomRepo.api.Models.GameSystem", "GameSystem")
                        .WithMany()
                        .HasForeignKey("GameSystemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");

                    b.Navigation("GameSystem");
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
                    b.Navigation("Attributes");

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
