using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Repositories
{

    public class GameRepository : IGameRepository
    {


        private readonly GameContext _context;
        private readonly DbSet<Game> _games;

        public GameRepository(GameContext dbContext)
        {
            _context = dbContext;
            _games = dbContext.Games;
        }

        public void Add(Game game)
        {
            _games.Add(game);
        }

        public void Delete(Game game)
        {
            _games.Remove(game);
        }

        public IEnumerable<Game> GetAll()
        {
            return _games.ToList();
        }

        public Game GetBy(int id)
        {
            return _games.SingleOrDefault(g => g.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Game game)
        {
            _context.Update(game);
        }
    }
}
