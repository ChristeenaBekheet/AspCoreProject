using RealEstate.Data;
using RealEstate.Models;
using RealEstate.Models.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models.Repositries
{
    public class ReviewRepositry : IRepository<Review>
    {
        private readonly ApplicationDbContext context;

        public ReviewRepositry(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Add(Review entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Review Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Review> List()
        {
            throw new NotImplementedException();
        }

        public List<Review> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
