using DesafioAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioAPI.Data
{
    public class DesafioDataContext : DbContext 
    {
        public DesafioDataContext(DbContextOptions<DesafioDataContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
