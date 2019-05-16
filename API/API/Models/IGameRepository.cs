using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public interface IGameRepository
    {
        Game GetBy(int id);
        IEnumerable<Game> GetAll();
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void SaveChanges();
    }
}
