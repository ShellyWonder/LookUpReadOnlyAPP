using Microsoft.EntityFrameworkCore;

namespace LookUpReadOnlyAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<AERecordModel> AERecords { get; set; } = default!;
    }
}
