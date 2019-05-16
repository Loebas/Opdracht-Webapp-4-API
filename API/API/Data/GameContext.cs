using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class GameContext : DbContext
    {

        public GameContext(DbContextOptions<GameContext> options): base(options)
        {

        }

    public DbSet<Game> Games { get; set; }
    }
}
