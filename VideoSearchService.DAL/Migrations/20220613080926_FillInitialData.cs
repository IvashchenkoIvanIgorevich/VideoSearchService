using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoSearchService.DAL.Migrations
{
    public partial class FillInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorProfessions_Actors_ProfessionId",
                table: "ActorProfessions");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorProfessions_Professions_ActorId",
                table: "ActorProfessions");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Actors_MovieId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Movies_ActorId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_GenreId",
                table: "MovieGenres");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Description", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Robert John Downey Jr. is an American actor and producer. His career has been characterized by critical and popular success in his youth, followed by a period of substance abuse and legal troubles, before a resurgence of commercial success later in his career.", "Robert", "Downey Jr." },
                    { 2, "Christopher Hemsworth AM is an Australian actor. He rose to prominence playing Kim Hyde in the Australian television series Home and Away before beginning a film career in Hollywood.", "Chris", "Hemsworth" },
                    { 3, "Mark Alan Ruffalo is an American actor. He began acting in the early 1990s and first gained recognition for his work in Kenneth Lonergan's play This Is Our Youth and drama film You Can Count On Me.", "Mark", "Ruffalo" },
                    { 4, "Christopher Robert Evans is an American actor. He began his career with roles in television series, such as in Opposite Sex in 2000.", "Chris", "Evans" },
                    { 5, "Benedict Timothy Carlton Cumberbatch CBE is an English actor. Known for his work on screen and stage, he has received various accolades, including a British Academy Television Award, a Primetime Emmy", "Benedict", "Cumberbatch" },
                    { 6, "Thomas Stanley Holland is an English actor. His accolades include a British Academy Film Award, three Saturn Awards, a Guinness World Record and an appearance on the Forbes 30 Under 30 Europe list. Some publications have called him one of the most popular actors of his generation.", "Tom", "Holland" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Drama" },
                    { 9, "Horror" },
                    { 7, "Detective" },
                    { 6, "Fantasy" },
                    { 8, "Family" },
                    { 4, "Comedy" },
                    { 3, "Thriller" },
                    { 2, "Action movie" },
                    { 1, "Adventure" },
                    { 5, "Fantastic" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AgeLimit", "Description", "Duration", "Title", "Year" },
                values: new object[,]
                {
                    { 10, (byte)16, "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.", (short)138, "The Hobbit: The Battle of the Five Armies", "2014" },
                    { 1, (byte)16, "Deprived of his mighty hammer Mjolnir, Thor must escape the other side of the universe to save his home, Asgard, from Hela, the goddess of death.", (short)125, "Thor: Ragnarok", "2017" },
                    { 2, (byte)16, "After Thanos, an intergalactic warlord, disintegrates half of the universe, the Avengers must reunite and assemble again to reinvigorate their trounced allies and restore balance.", (short)174, "Avengers: Endgame", "2019" },
                    { 3, (byte)12, "Peter Parker seeks Doctor Strange's help to make people forget about Spiderman's identity. However, when the spell he casts gets corrupted, several unwanted guests enter their universe.", (short)195, "Spider-Man: No Way Home", "2021" },
                    { 4, (byte)12, "Victor Sullivan recruits Nathan Drake to help him find the lost fortune of Ferdinand Magellan. However, they face competition from Santiago Moncada, who believes that the treasure belongs to him.", (short)200, "Uncharted", "2022" },
                    { 5, (byte)16, "Friction arises between the Avengers when one group supports the government's decision to implement a law to control their powers while the other opposes it.", (short)142, "Captain America: Civil War", "2016" },
                    { 6, (byte)12, "Sherlock Holmes is a 2009 period mystery action film based on the character of the same name created by Sir Arthur Conan Doyle. ", (short)123, "Sherlock Holmes", "2009" },
                    { 7, (byte)12, "A physician, who can speak with animals, is summoned by the queen to find a cure for her life-threatening disease. Soon, he embarks on a journey with his furry friends in search of a healing tree.", (short)101, "Dolittle", "2020" },
                    { 8, (byte)12, "Dr Stephen Strange casts a forbidden spell that opens a portal to the multiverse. However, a threat emerges that may be too big for his team to handle.", (short)187, "Doctor Strange in the Multiverse of Madness", "2022" },
                    { 9, (byte)16, "A defence attorney, her associate, and a military prosecutor uncover a far-reaching conspiracy while investigating the case of a suspected 9/11 terrorist imprisoned at Guantanamo Bay, Cuba, for six years.", (short)129, "The Mauritanian", "2021" },
                    { 11, (byte)14, "Set more than seven years after the world has become a frozen wasteland, this series centres on the remaining people, who inhabit a gigantic, perpetually-moving train that circles the globe.", (short)125, "Snowpiercer", "2013" }
                });

            migrationBuilder.InsertData(
                table: "ActorProfessions",
                columns: new[] { "ActorId", "ProfessionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 6, 1 },
                    { 5, 1 },
                    { 4, 3 },
                    { 4, 2 },
                    { 4, 1 },
                    { 3, 4 },
                    { 6, 3 },
                    { 3, 2 },
                    { 3, 1 },
                    { 2, 1 },
                    { 1, 4 },
                    { 1, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 5, 3 },
                    { 6, 3 },
                    { 6, 4 },
                    { 5, 10 },
                    { 1, 5 },
                    { 1, 6 },
                    { 6, 5 },
                    { 1, 7 },
                    { 5, 8 },
                    { 6, 8 },
                    { 4, 11 },
                    { 4, 5 },
                    { 5, 2 },
                    { 5, 9 },
                    { 3, 2 },
                    { 5, 1 },
                    { 3, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 4, 2 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 5, 8 },
                    { 6, 8 },
                    { 2, 5 },
                    { 8, 7 },
                    { 6, 7 },
                    { 4, 7 },
                    { 9, 8 },
                    { 7, 6 },
                    { 3, 6 },
                    { 1, 1 },
                    { 5, 5 },
                    { 2, 8 },
                    { 10, 9 },
                    { 2, 1 },
                    { 5, 1 },
                    { 2, 2 },
                    { 5, 2 },
                    { 3, 9 },
                    { 2, 11 },
                    { 1, 3 },
                    { 2, 3 },
                    { 4, 1 },
                    { 5, 3 },
                    { 10, 11 },
                    { 5, 11 },
                    { 1, 4 },
                    { 2, 4 },
                    { 6, 1 },
                    { 1, 10 },
                    { 6, 10 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Mark", "MovieId", "Name" },
                values: new object[,]
                {
                    { 11, 4.2999999999999998, 9, "Metacritic" },
                    { 12, 9.5999999999999996, 10, "MGG" },
                    { 16, 5.2000000000000002, 10, "Metacritic" },
                    { 14, 8.0999999999999996, 9, "Netflix" },
                    { 18, 7.5, 3, "MGG" },
                    { 15, 4.5, 7, "IMDB" },
                    { 10, 5.5999999999999996, 6, "IMDB" },
                    { 9, 8.1999999999999993, 5, "IMDB" },
                    { 8, 9.0999999999999996, 4, "IMDB" },
                    { 6, 4.4000000000000004, 3, "IMDB" },
                    { 7, 8.5, 2, "MGG" },
                    { 5, 6.2999999999999998, 2, "Netflix" },
                    { 4, 5.5999999999999996, 2, "Metacritic" },
                    { 3, 7.0, 2, "IMDB" },
                    { 2, 7.4000000000000004, 1, "MGG" },
                    { 1, 8.1999999999999993, 1, "IMDB" },
                    { 17, 8.1999999999999993, 8, "IMDB" },
                    { 13, 6.7999999999999998, 11, "Metacritic" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ActorProfessions_Actors_ActorId",
                table: "ActorProfessions",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorProfessions_Professions_ProfessionId",
                table: "ActorProfessions",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorProfessions_Actors_ActorId",
                table: "ActorProfessions");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorProfessions_Professions_ProfessionId",
                table: "ActorProfessions");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres");

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ActorProfessions",
                keyColumns: new[] { "ActorId", "ProfessionId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorProfessions_Actors_ProfessionId",
                table: "ActorProfessions",
                column: "ProfessionId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorProfessions_Professions_ActorId",
                table: "ActorProfessions",
                column: "ActorId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Actors_MovieId",
                table: "MovieActors",
                column: "MovieId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Movies_ActorId",
                table: "MovieActors",
                column: "ActorId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
