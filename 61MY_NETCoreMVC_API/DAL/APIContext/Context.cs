using _61MY_NETCoreMVC_API.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace _61MY_NETCoreMVC_API.DAL.APIContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SG606F1\\SQLEXPRESS;" +
                " Database=61MY_NETCoreMVCDb2_API; Integrated Security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
