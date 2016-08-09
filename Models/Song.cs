namespace COMP2007_S2016_Lesson12C.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Song : DbContext
    {
        // Your context has been configured to use a 'Song' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'COMP2007_S2016_Lesson12C.Models.Song' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Song' 
        // connection string in the application configuration file.
        public Song()
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual int SongId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Duration { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}