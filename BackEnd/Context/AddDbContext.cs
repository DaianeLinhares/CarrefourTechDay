using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Context
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
