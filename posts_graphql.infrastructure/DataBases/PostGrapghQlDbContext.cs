using Microsoft.EntityFrameworkCore;
using Posts_graphql.Infrastructure.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace Posts_graphql.Infrastructure
{
     public class PostGrapghQlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public PostGrapghQlDbContext(DbContextOptions<PostGrapghQlDbContext> options) : base(options)
        {
            
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseSqlServer("Server=DESKTOP-KDVQSF3\\YAWAR;Database=PostGraphQl;User Id=yawar;Password=123;");
        //     }
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings, relationships, etc. if needed
            base.OnModelCreating(modelBuilder);
        }

       
    }

    public class PostGrapghQlDbContextFactory : IDesignTimeDbContextFactory<PostGrapghQlDbContext>
{
    public PostGrapghQlDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PostGrapghQlDbContext>();
        optionsBuilder.UseSqlServer("Server=DESKTOP-KDVQSF3\\YAWAR;Database=PostGraphQl;User Id=yawar;Password=123;");

        return new PostGrapghQlDbContext(optionsBuilder.Options);
    }
}
}