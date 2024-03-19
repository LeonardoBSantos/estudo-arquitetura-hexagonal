using Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.iAdapters
{
    public interface IRepository
    {
        public void CreateData();
        public Entity1 GetData();
    }
}
