using System;
using System.Data.Entity;
using System.Linq;

namespace Day16Lab14.Models
{
    public class Wizarding_World : DbContext
    {
        // Your context has been configured to use a 'Wizarding_World' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Day16Lab14.Models.Wizarding_World' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Wizarding_World' 
        // connection string in the application configuration file.
        public Wizarding_World()
            : base("name=Wizarding World")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<House> Houses { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}