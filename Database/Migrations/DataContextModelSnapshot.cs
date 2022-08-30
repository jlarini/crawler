﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Database.Entities.MatchEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"), 1L, 1);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MatchId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ProfileEntityId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal?>("UserId")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileEntityId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchEntity");
                });

            modelBuilder.Entity("Database.Entities.ProfileEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"), 1L, 1);

                    b.Property<string>("AvatarHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Banned")
                        .HasColumnType("bit");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Flags")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("RecentStatsId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("StatsId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecentStatsId");

                    b.HasIndex("StatsId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Database.Entities.RecentStatsEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"), 1L, 1);

                    b.Property<int>("RecentDeaths")
                        .HasColumnType("int");

                    b.Property<int>("RecentDrops")
                        .HasColumnType("int");

                    b.Property<int>("RecentHeadshots")
                        .HasColumnType("int");

                    b.Property<int>("RecentKills")
                        .HasColumnType("int");

                    b.Property<int>("RecentLosses")
                        .HasColumnType("int");

                    b.Property<int>("RecentMatches")
                        .HasColumnType("int");

                    b.Property<int>("RecentWins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RecentStatsEntity");
                });

            modelBuilder.Entity("Database.Entities.StatsEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"), 1L, 1);

                    b.Property<int>("Aces")
                        .HasColumnType("int");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("AwpDuelWins")
                        .HasColumnType("int");

                    b.Property<int>("BananaKills")
                        .HasColumnType("int");

                    b.Property<int>("BombDefuses")
                        .HasColumnType("int");

                    b.Property<int>("BombPlants")
                        .HasColumnType("int");

                    b.Property<int>("Clutches")
                        .HasColumnType("int");

                    b.Property<int>("DamageDealt")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<int>("Dominations")
                        .HasColumnType("int");

                    b.Property<int>("Drops")
                        .HasColumnType("int");

                    b.Property<int>("EcoAces")
                        .HasColumnType("int");

                    b.Property<int>("EcoWins")
                        .HasColumnType("int");

                    b.Property<int>("Elo")
                        .HasColumnType("int");

                    b.Property<int>("FragSteals")
                        .HasColumnType("int");

                    b.Property<int>("GamesAsLegend")
                        .HasColumnType("int");

                    b.Property<int>("GatherDrops")
                        .HasColumnType("int");

                    b.Property<int>("GathersCreated")
                        .HasColumnType("int");

                    b.Property<int>("GathersPlayed")
                        .HasColumnType("int");

                    b.Property<int>("Headshots")
                        .HasColumnType("int");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("LongestLosingStreak")
                        .HasColumnType("int");

                    b.Property<int>("LongestWinningStreak")
                        .HasColumnType("int");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<int>("Matches")
                        .HasColumnType("int");

                    b.Property<int>("MidDustKills")
                        .HasColumnType("int");

                    b.Property<int>("Mvps")
                        .HasColumnType("int");

                    b.Property<int>("OneHpSurvivals")
                        .HasColumnType("int");

                    b.Property<int>("OpeningDeaths")
                        .HasColumnType("int");

                    b.Property<int>("OpeningDuelWins")
                        .HasColumnType("int");

                    b.Property<int>("OpeningKills")
                        .HasColumnType("int");

                    b.Property<int>("OvertimeWins")
                        .HasColumnType("int");

                    b.Property<decimal>("PremiumElapsedTime")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal?>("Rank")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int>("Rounds")
                        .HasColumnType("int");

                    b.Property<int>("Scores100")
                        .HasColumnType("int");

                    b.Property<int>("ThumbsDown")
                        .HasColumnType("int");

                    b.Property<int>("ThumbsUp")
                        .HasColumnType("int");

                    b.Property<int>("TopFrags")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.Property<int>("kdOver3")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StatsEntity");
                });

            modelBuilder.Entity("Database.Entities.UserEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"), 1L, 1);

                    b.Property<string>("AvatarHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("DisplayMedals")
                        .HasColumnType("int");

                    b.Property<decimal>("Flags")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<decimal?>("ProfileEntityId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("SubregionId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileEntityId");

                    b.ToTable("UserEntity");
                });

            modelBuilder.Entity("Database.Entities.UsernameEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"), 1L, 1);

                    b.Property<decimal?>("ProfileEntityId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileEntityId");

                    b.ToTable("UsernameEntity");
                });

            modelBuilder.Entity("Database.Entities.MatchEntity", b =>
                {
                    b.HasOne("Database.Entities.ProfileEntity", null)
                        .WithMany("MatchDrops")
                        .HasForeignKey("ProfileEntityId");

                    b.HasOne("Database.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Database.Entities.ProfileEntity", b =>
                {
                    b.HasOne("Database.Entities.RecentStatsEntity", "RecentStats")
                        .WithMany()
                        .HasForeignKey("RecentStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Entities.StatsEntity", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecentStats");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("Database.Entities.UserEntity", b =>
                {
                    b.HasOne("Database.Entities.ProfileEntity", null)
                        .WithMany("Friends")
                        .HasForeignKey("ProfileEntityId");
                });

            modelBuilder.Entity("Database.Entities.UsernameEntity", b =>
                {
                    b.HasOne("Database.Entities.ProfileEntity", null)
                        .WithMany("OldUsernames")
                        .HasForeignKey("ProfileEntityId");
                });

            modelBuilder.Entity("Database.Entities.ProfileEntity", b =>
                {
                    b.Navigation("Friends");

                    b.Navigation("MatchDrops");

                    b.Navigation("OldUsernames");
                });
#pragma warning restore 612, 618
        }
    }
}
