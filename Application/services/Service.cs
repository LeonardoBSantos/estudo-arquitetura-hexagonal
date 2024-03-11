using Domain.entities;
using Domain.entities.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
    public class Service : IService
    {
        public Entity1 entity1 { get; set; }
        public Entity2 entity2 { get; set; }

        public Service()
        {
             this.entity1 = new Entity1();
             this.entity2 = new Entity2();
        }

        public int SumInts()
        {
            entity1.IntA = 2;
            entity2.IntB = 2;

            return entity1.IntA + entity2.IntB;
        }
    }
}
