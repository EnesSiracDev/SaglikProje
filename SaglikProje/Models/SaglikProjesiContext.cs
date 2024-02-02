using Microsoft.EntityFrameworkCore;

namespace SaglikProje.Models
{
    public class SaglikProjesiContext :DbContext
    {
        public SaglikProjesiContext()
        {
        }

        public SaglikProjesiContext(DbContextOptions<SaglikProjesiContext> options) : base(options)
        {

        }

        public DbSet<Belirti> Belirtis { get; set; }
    }
}
