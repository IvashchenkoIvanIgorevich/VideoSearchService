﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VideoSearchService.DAL;

namespace VideoSearchService.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("VideoSearchService.Data.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("LastName")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Robert John Downey Jr. is an American actor and producer. His career has been characterized by critical and popular success in his youth, followed by a period of substance abuse and legal troubles, before a resurgence of commercial success later in his career.",
                            FirstName = "Robert",
                            LastName = "Downey Jr."
                        },
                        new
                        {
                            Id = 2,
                            Description = "Christopher Hemsworth AM is an Australian actor. He rose to prominence playing Kim Hyde in the Australian television series Home and Away before beginning a film career in Hollywood.",
                            FirstName = "Chris",
                            LastName = "Hemsworth"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Mark Alan Ruffalo is an American actor. He began acting in the early 1990s and first gained recognition for his work in Kenneth Lonergan's play This Is Our Youth and drama film You Can Count On Me.",
                            FirstName = "Mark",
                            LastName = "Ruffalo"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Christopher Robert Evans is an American actor. He began his career with roles in television series, such as in Opposite Sex in 2000.",
                            FirstName = "Chris",
                            LastName = "Evans"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Benedict Timothy Carlton Cumberbatch CBE is an English actor. Known for his work on screen and stage, he has received various accolades, including a British Academy Television Award, a Primetime Emmy",
                            FirstName = "Benedict",
                            LastName = "Cumberbatch"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Thomas Stanley Holland is an English actor. His accolades include a British Academy Film Award, three Saturn Awards, a Guinness World Record and an appearance on the Forbes 30 Under 30 Europe list. Some publications have called him one of the most popular actors of his generation.",
                            FirstName = "Tom",
                            LastName = "Holland"
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.ActorProfession", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfessionId")
                        .HasColumnType("integer");

                    b.HasKey("ActorId", "ProfessionId");

                    b.HasIndex("ProfessionId");

                    b.ToTable("ActorProfessions");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            ProfessionId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            ProfessionId = 2
                        },
                        new
                        {
                            ActorId = 1,
                            ProfessionId = 4
                        },
                        new
                        {
                            ActorId = 2,
                            ProfessionId = 1
                        },
                        new
                        {
                            ActorId = 3,
                            ProfessionId = 1
                        },
                        new
                        {
                            ActorId = 3,
                            ProfessionId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            ProfessionId = 3
                        },
                        new
                        {
                            ActorId = 3,
                            ProfessionId = 4
                        },
                        new
                        {
                            ActorId = 4,
                            ProfessionId = 1
                        },
                        new
                        {
                            ActorId = 4,
                            ProfessionId = 2
                        },
                        new
                        {
                            ActorId = 4,
                            ProfessionId = 3
                        },
                        new
                        {
                            ActorId = 5,
                            ProfessionId = 1
                        },
                        new
                        {
                            ActorId = 6,
                            ProfessionId = 1
                        },
                        new
                        {
                            ActorId = 6,
                            ProfessionId = 3
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Action movie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fantastic"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Detective"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<byte>("AgeLimit")
                        .HasColumnType("smallint");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<short>("Duration")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgeLimit = (byte)16,
                            Description = "Deprived of his mighty hammer Mjolnir, Thor must escape the other side of the universe to save his home, Asgard, from Hela, the goddess of death.",
                            Duration = (short)125,
                            Title = "Thor: Ragnarok",
                            Year = "2017"
                        },
                        new
                        {
                            Id = 2,
                            AgeLimit = (byte)16,
                            Description = "After Thanos, an intergalactic warlord, disintegrates half of the universe, the Avengers must reunite and assemble again to reinvigorate their trounced allies and restore balance.",
                            Duration = (short)174,
                            Title = "Avengers: Endgame",
                            Year = "2019"
                        },
                        new
                        {
                            Id = 3,
                            AgeLimit = (byte)12,
                            Description = "Peter Parker seeks Doctor Strange's help to make people forget about Spiderman's identity. However, when the spell he casts gets corrupted, several unwanted guests enter their universe.",
                            Duration = (short)195,
                            Title = "Spider-Man: No Way Home",
                            Year = "2021"
                        },
                        new
                        {
                            Id = 4,
                            AgeLimit = (byte)12,
                            Description = "Victor Sullivan recruits Nathan Drake to help him find the lost fortune of Ferdinand Magellan. However, they face competition from Santiago Moncada, who believes that the treasure belongs to him.",
                            Duration = (short)200,
                            Title = "Uncharted",
                            Year = "2022"
                        },
                        new
                        {
                            Id = 5,
                            AgeLimit = (byte)16,
                            Description = "Friction arises between the Avengers when one group supports the government's decision to implement a law to control their powers while the other opposes it.",
                            Duration = (short)142,
                            Title = "Captain America: Civil War",
                            Year = "2016"
                        },
                        new
                        {
                            Id = 6,
                            AgeLimit = (byte)12,
                            Description = "Sherlock Holmes is a 2009 period mystery action film based on the character of the same name created by Sir Arthur Conan Doyle. ",
                            Duration = (short)123,
                            Title = "Sherlock Holmes",
                            Year = "2009"
                        },
                        new
                        {
                            Id = 7,
                            AgeLimit = (byte)12,
                            Description = "A physician, who can speak with animals, is summoned by the queen to find a cure for her life-threatening disease. Soon, he embarks on a journey with his furry friends in search of a healing tree.",
                            Duration = (short)101,
                            Title = "Dolittle",
                            Year = "2020"
                        },
                        new
                        {
                            Id = 8,
                            AgeLimit = (byte)12,
                            Description = "Dr Stephen Strange casts a forbidden spell that opens a portal to the multiverse. However, a threat emerges that may be too big for his team to handle.",
                            Duration = (short)187,
                            Title = "Doctor Strange in the Multiverse of Madness",
                            Year = "2022"
                        },
                        new
                        {
                            Id = 9,
                            AgeLimit = (byte)16,
                            Description = "A defence attorney, her associate, and a military prosecutor uncover a far-reaching conspiracy while investigating the case of a suspected 9/11 terrorist imprisoned at Guantanamo Bay, Cuba, for six years.",
                            Duration = (short)129,
                            Title = "The Mauritanian",
                            Year = "2021"
                        },
                        new
                        {
                            Id = 10,
                            AgeLimit = (byte)16,
                            Description = "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.",
                            Duration = (short)138,
                            Title = "The Hobbit: The Battle of the Five Armies",
                            Year = "2014"
                        },
                        new
                        {
                            Id = 11,
                            AgeLimit = (byte)14,
                            Description = "Set more than seven years after the world has become a frozen wasteland, this series centres on the remaining people, who inhabit a gigantic, perpetually-moving train that circles the globe.",
                            Duration = (short)125,
                            Title = "Snowpiercer",
                            Year = "2013"
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.MovieActor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 3
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 5
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 3
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 4
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 5
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 5
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 6
                        },
                        new
                        {
                            MovieId = 4,
                            ActorId = 6
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 4
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 6
                        },
                        new
                        {
                            MovieId = 6,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 7,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 8,
                            ActorId = 5
                        },
                        new
                        {
                            MovieId = 8,
                            ActorId = 6
                        },
                        new
                        {
                            MovieId = 9,
                            ActorId = 5
                        },
                        new
                        {
                            MovieId = 10,
                            ActorId = 5
                        },
                        new
                        {
                            MovieId = 11,
                            ActorId = 4
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenres");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 4
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 6
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 6,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 6,
                            GenreId = 7
                        },
                        new
                        {
                            MovieId = 7,
                            GenreId = 4
                        },
                        new
                        {
                            MovieId = 7,
                            GenreId = 6
                        },
                        new
                        {
                            MovieId = 7,
                            GenreId = 8
                        },
                        new
                        {
                            MovieId = 8,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 8,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 8,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 8,
                            GenreId = 6
                        },
                        new
                        {
                            MovieId = 8,
                            GenreId = 9
                        },
                        new
                        {
                            MovieId = 9,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 9,
                            GenreId = 10
                        },
                        new
                        {
                            MovieId = 10,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 10,
                            GenreId = 6
                        },
                        new
                        {
                            MovieId = 11,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 11,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 11,
                            GenreId = 10
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.ToTable("Professions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Actor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Producer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Director"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Screenwriter"
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<double>("Mark")
                        .HasColumnType("double precision");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mark = 8.1999999999999993,
                            MovieId = 1,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 2,
                            Mark = 7.4000000000000004,
                            MovieId = 1,
                            Name = "MGG"
                        },
                        new
                        {
                            Id = 3,
                            Mark = 7.0,
                            MovieId = 2,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 4,
                            Mark = 5.5999999999999996,
                            MovieId = 2,
                            Name = "Metacritic"
                        },
                        new
                        {
                            Id = 5,
                            Mark = 6.2999999999999998,
                            MovieId = 2,
                            Name = "Netflix"
                        },
                        new
                        {
                            Id = 6,
                            Mark = 4.4000000000000004,
                            MovieId = 3,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 7,
                            Mark = 8.5,
                            MovieId = 2,
                            Name = "MGG"
                        },
                        new
                        {
                            Id = 8,
                            Mark = 9.0999999999999996,
                            MovieId = 4,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 9,
                            Mark = 8.1999999999999993,
                            MovieId = 5,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 10,
                            Mark = 5.5999999999999996,
                            MovieId = 6,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 11,
                            Mark = 4.2999999999999998,
                            MovieId = 9,
                            Name = "Metacritic"
                        },
                        new
                        {
                            Id = 12,
                            Mark = 9.5999999999999996,
                            MovieId = 10,
                            Name = "MGG"
                        },
                        new
                        {
                            Id = 13,
                            Mark = 6.7999999999999998,
                            MovieId = 11,
                            Name = "Metacritic"
                        },
                        new
                        {
                            Id = 14,
                            Mark = 8.0999999999999996,
                            MovieId = 9,
                            Name = "Netflix"
                        },
                        new
                        {
                            Id = 15,
                            Mark = 4.5,
                            MovieId = 7,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 16,
                            Mark = 5.2000000000000002,
                            MovieId = 10,
                            Name = "Metacritic"
                        },
                        new
                        {
                            Id = 17,
                            Mark = 8.1999999999999993,
                            MovieId = 8,
                            Name = "IMDB"
                        },
                        new
                        {
                            Id = 18,
                            Mark = 7.5,
                            MovieId = 3,
                            Name = "MGG"
                        });
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.ActorProfession", b =>
                {
                    b.HasOne("VideoSearchService.Data.Models.Actor", "Actor")
                        .WithMany("ActorProfessions")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VideoSearchService.Data.Models.Profession", "Profession")
                        .WithMany("ActorProfessions")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.MovieActor", b =>
                {
                    b.HasOne("VideoSearchService.Data.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VideoSearchService.Data.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.MovieGenre", b =>
                {
                    b.HasOne("VideoSearchService.Data.Models.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VideoSearchService.Data.Models.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Rating", b =>
                {
                    b.HasOne("VideoSearchService.Data.Models.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Actor", b =>
                {
                    b.Navigation("ActorProfessions");

                    b.Navigation("MovieActors");
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Genre", b =>
                {
                    b.Navigation("MovieGenres");
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Movie", b =>
                {
                    b.Navigation("MovieActors");

                    b.Navigation("MovieGenres");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("VideoSearchService.Data.Models.Profession", b =>
                {
                    b.Navigation("ActorProfessions");
                });
#pragma warning restore 612, 618
        }
    }
}
