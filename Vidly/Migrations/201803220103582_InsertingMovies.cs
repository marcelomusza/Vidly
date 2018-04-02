namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingMovies : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId) VALUES ('Shrek', '10/10/1984', 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId) VALUES ('Terminator', '10/12/1984', 5)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId) VALUES ('Jurassic Park', '10/10/1996', 6)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, GenreId) VALUES ('Lord of the Rings', '02/11/2000', 6)");

        }
        
        public override void Down()
        {
        }
    }
}
