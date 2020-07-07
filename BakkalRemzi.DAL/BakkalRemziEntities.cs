using BakkalRemzi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalRemzi.DAL
{
    public class BakkalRemziEntities : DbContext
    {
        //RemziBakkalDb
        public BakkalRemziEntities() : base("name=RemziBakkalDbConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
