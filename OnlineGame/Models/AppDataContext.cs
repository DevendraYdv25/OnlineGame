using Microsoft.EntityFrameworkCore;//DbContext class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGame.Models
{
    public class AppDataContext:DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) :base(options)
        {

        }
        public DbSet<OnlineGame1> GameTBL { get; set; }
    }
}
