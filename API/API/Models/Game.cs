using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string SpelNaam { get; set; }
        public int MinSpelers { get; set; }
        public int MaxSpelers { get; set; }
        public int Difficulty { get; set; }

        public Game()
        {

        }
    }

   

}
