using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Music_Mash.Models;

namespace Music_Mash.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Music_Mash.Models.Music> Music { get; set; } = default!;
        public DbSet<Music_Mash.Models.List> List { get; set; } = default!;
    }
}
