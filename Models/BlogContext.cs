using Microsoft.EntityFrameworkCore;

namespace BlazorServerExample.Models
{

    public class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> opt) : base(opt) { }

        public DbSet<BlogEntry> Entries { get; set; }

    }

}