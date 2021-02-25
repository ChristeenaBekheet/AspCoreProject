using RealEstate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models.Repositries
{
    public class PropertyRepositry : IRepository<Property>
    {
        private readonly ApplicationDbContext context;

        public PropertyRepositry(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Add(Property entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Property Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Property> List()
        {
            throw new NotImplementedException();
        }

        public List<Property> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Property entity)
        {
            throw new NotImplementedException();
        }
    }
}
