using Microsoft.EntityFrameworkCore;

namespace Business.Models
{
    public class BusinessContext : DbContext
    {
       
    public virtual DbSet<Charity> Charities { get; set; } 
    public DbSet<BoardMember> BoardMembers { get; set; }

    public BusinessContext(DbContextOptions options) : base(options) { }

    }
}