using ConsoleProject.Models;
using ConsoleProject.Enums;
using Microsoft.EntityFrameworkCore;

namespace WebAPIProject.Context
{
    // ApplicationContext is a DbContext class that manages the database context for the application.
    public class ApplicationContext : DbContext
    {
        // Constructor that takes DbContextOptions<ApplicationContext> as a parameter and passes it to the base class constructor.
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            // The constructor is empty because we only need to pass options to the base class.
        }

        // Method called during the database model creation. It's used for configuring the entity models.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Call the base class method for any default configuration.
            base.OnModelCreating(builder);

            // Use the builder to configure the entity models and relationships.

            // Seed initial data for the Stage entity.
            builder.Entity<Stage>().HasData(
                new Stage
                {
                    StageType = StageType.Applied,
                    StageName = "Applied",
                }
            );
        }

        // DbSet for the Program entity, which represents a collection of Program objects in the database.
        public DbSet<ConsoleProject.Models.Program> Programs { get; set; }

        // DbSet for the Question entity, which represents a collection of Question objects in the database.
        public DbSet<Question> Questions { get; set; }

        // DbSet for the Stage entity, which represents a collection of Stage objects in the database.
        public DbSet<Stage> Stages { get; set; }

        // DbSet for the Application entity, which represents a collection of Application objects in the database.
        public DbSet<Application> Applications { get; set; }
    }
}
