using AlugaSe.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.Infrastructure.DataAccess.Factories
{
    public class AlugaSeContextFactory : IDesignTimeDbContextFactory<AlugaSeContext>
    {

        public AlugaSeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AlugaSeContext>();

            var location = AppDomain.CurrentDomain.BaseDirectory + @"\DB";

            //optionsBuilder.UseSqlServer(@"Data Source=" + location + ";Initial Catalog=AlugaSeDB;Integrated Security=True;");
           // optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AlugaSe;Integrated Security=True;");
           optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cadu\Documents\Workspace\Infnet\AlugaSe\AlugaSe\AlugaSe.Infrastructure.DataAccess\DB\AlugaSe.mdf;Integrated Security=True");



            return new AlugaSeContext(optionsBuilder.Options);
        }

    }
}
