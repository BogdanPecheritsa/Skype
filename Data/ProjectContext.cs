using CALLОМОЙСЬКИЙ.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CALLОМОЙСЬКИЙ.Data;

public class ProjectContext : DbContext
{
    public DbSet<Call> Calls { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Contact> Contacts { get; set; }
        
    public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
    {
    }
}