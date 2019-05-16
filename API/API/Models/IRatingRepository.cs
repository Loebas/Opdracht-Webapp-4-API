using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    interface IRatingRepository
    {
        IEnumerable<Rating> GetAll();
        IEnumerable<Rating> GetBy(int gameId);
        void Add(Rating rating);
        void Update(Rating rating);
        void SaveChanges();

    }
}
