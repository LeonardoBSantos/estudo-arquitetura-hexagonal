using Domain.entities;
using Domain.iAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDb.repositories
{
    public class Repository: IRepository
    {
        public ApplicationDbContext context { get; set; }

        public Repository()
        {
            this.context = new ApplicationDbContext();
        }

        public void CreateData()
        {
            context.Entity1.Add(new Entity1 { IdExemplo = "exemplo", IntA = 2, IntB = 2});

            context.SaveChanges();
        }

        public Entity1 GetData()
        {
            var entidades = context.Entity1.Find("exemplo");

            return entidades;
        }
    }
}
