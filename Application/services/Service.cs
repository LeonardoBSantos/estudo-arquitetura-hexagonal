using Domain.entities;
using Domain.entities.IServices;
using Domain.iAdapters;
using InMemoryDb.repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
    public class Service : IService
    {
        public IRepository repository { get; set; }

        public Service()
        {
            this.repository = new Repository();
        }

        public int SumInts()
        {
            var sum = 0;
            repository.CreateData();
            var listInts = repository.GetData();
            sum = listInts.IntA + listInts.IntB;

            return sum;
        }
    }
}
