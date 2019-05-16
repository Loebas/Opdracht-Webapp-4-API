using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {

        private readonly IGameRepository _gameRepository;

        public GamesController(IGameRepository context)
        {
            _gameRepository = context;
        }

        // get game with id
        [HttpGet("{id}")]
        public ActionResult<Game> GetGame(int id)
        {
            Game recipe = _gameRepository.GetBy(id);
            if (recipe == null) return NotFound();
            return recipe;
        }

        // get all games
        [HttpGet]
        public IEnumerable<Game> GetGames()
        {
            return _gameRepository.GetAll().OrderBy(g => g.SpelNaam);
        }

     
    }
}