using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApp_Demo.Models;

namespace WebApp_Demo.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        // Table name
        public DbSet<MyTree> myTrees { get; set; }
    }
}
