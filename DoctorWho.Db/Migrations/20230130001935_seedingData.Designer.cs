﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20230130001935_seedingData")]
    partial class seedingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Author1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Author2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Author3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Author4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Author5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("companions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Companion1",
                            WhoPlayed = "x"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Companion2",
                            WhoPlayed = "y"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Companion3",
                            WhoPlayed = "z"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Companion4",
                            WhoPlayed = "e"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Companion5",
                            WhoPlayed = "w"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.CompanionEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("episodeCompanions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanionId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            Id = 2,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            Id = 3,
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            Id = 4,
                            CompanionId = 3,
                            EpisodeId = 2
                        },
                        new
                        {
                            Id = 5,
                            CompanionId = 5,
                            EpisodeId = 4
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(1912, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1941, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor1",
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1950, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(1950, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1901, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor2",
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1959, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(1900, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1944, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor3",
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1927, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(1924, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1941, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor4",
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1992, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(1942, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1944, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor5",
                            Number = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("enemys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description1",
                            Name = "Enemy1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description2",
                            Name = "Enemy2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description3",
                            Name = "Enemy3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description4",
                            Name = "Enemy4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description5",
                            Name = "Enemy5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EnemyEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("episodeEnemies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnemyId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            Id = 2,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            Id = 3,
                            EnemyId = 5,
                            EpisodeId = 2
                        },
                        new
                        {
                            Id = 4,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            Id = 5,
                            EnemyId = 5,
                            EpisodeId = 1
                        },
                        new
                        {
                            Id = 6,
                            EnemyId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            Id = 7,
                            EnemyId = 2,
                            EpisodeId = 4
                        },
                        new
                        {
                            Id = 8,
                            EnemyId = 2,
                            EpisodeId = 1
                        },
                        new
                        {
                            Id = 9,
                            EnemyId = 1,
                            EpisodeId = 3
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("episodes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 3,
                            Date = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorId = 1,
                            Notes = "Note1",
                            Number = 1,
                            SeriesNumber = 1,
                            Title = "Title1",
                            Type = "type1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Date = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorId = 5,
                            Notes = "Note2",
                            Number = 2,
                            SeriesNumber = 2,
                            Title = "Title2",
                            Type = "type2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Date = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorId = 2,
                            Notes = "Note3",
                            Number = 3,
                            SeriesNumber = 3,
                            Title = "Title3",
                            Type = "type3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Date = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorId = 5,
                            Notes = "Note4",
                            Number = 4,
                            SeriesNumber = 4,
                            Title = "Title4",
                            Type = "type4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Date = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Note5",
                            Number = 5,
                            SeriesNumber = 5,
                            Title = "Title5",
                            Type = "type5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 2,
                            Date = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorId = 1,
                            Notes = "Note6",
                            Number = 6,
                            SeriesNumber = 6,
                            Title = "Title6",
                            Type = "type6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 5,
                            Date = new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Note7",
                            Number = 7,
                            SeriesNumber = 7,
                            Title = "Title7",
                            Type = "type7"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.CompanionEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Companion", "companion")
                        .WithMany("companionEpisodes")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "episode")
                        .WithMany("companionEpisode")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("companion");

                    b.Navigation("episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EnemyEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Enemy", "enemy")
                        .WithMany("enemyEpisodes")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "episode")
                        .WithMany("enemyEpisode")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("enemy");

                    b.Navigation("episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Author", null)
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Doctor", null)
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Navigation("companionEpisodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Navigation("enemyEpisodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Navigation("companionEpisode");

                    b.Navigation("enemyEpisode");
                });
#pragma warning restore 612, 618
        }
    }
}
