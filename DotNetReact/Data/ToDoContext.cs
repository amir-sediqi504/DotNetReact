using DotNetReact.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetReact.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
           : base(options)
        {
        }

        public DbSet<Notes> Notes { get; set; }
    }
}
