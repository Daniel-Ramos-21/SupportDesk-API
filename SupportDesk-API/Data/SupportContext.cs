using Microsoft.EntityFrameworkCore;

namespace SupportDesk_API.Data
{
    public class SupportContext : DbContext
    {
        public SupportContext(DbContextOptions<SupportContext> options) : base(options)
        {

        }


    }
}
