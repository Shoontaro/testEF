using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace testEF
{
    
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public string connectionString;
        // или 

        //public DbSet<User> Users { get; set; } = null!;

        //public ApplicationContext() => Database.EnsureCreated(); // гарант что бд создана
        //or
        //public ApplicationContext(/*string connectionString*/)
        //{
        //    this.connectionString = connectionString;   // получаем извне строку подключения
        //    //Database.EnsureDeleted();   // удаляем бд со старой схемой
        //    //Database.EnsureCreated();   // создаем бд с новой схемой
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(connectionString);
        //    //optionsBuilder.EnableSensitiveDataLogging(true);
        //}

        public ApplicationContext()
        {
            //    Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
