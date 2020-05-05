using BlazorApp_TodoList_ComIT.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_TodoList_ComIT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    
        public DbSet<Todo> Todos { get; set; }
    }
}
