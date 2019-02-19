using Microsoft.EntityFrameworkCore;
using RJP.EntityModels;

namespace RJP.DAL
{
    public class DataContext : DbContext
    {      
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
           
        public DbSet<Movie> Movies { get; set; }        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);           
        }
    }
}
