using Microsoft.EntityFrameworkCore;
using SupportDesk_API.Models;

namespace SupportDesk_API.Data
{
    public class SupportContext : DbContext
    {
        public SupportContext(DbContextOptions<SupportContext> options) : base(options)
        {

        }

        public DbSet<Ejemplo> Ejemplos { get; set; }

    }
}
