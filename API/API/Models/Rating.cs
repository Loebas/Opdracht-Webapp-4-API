using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Rating
    {
        public Game ratedGame { get; set; }
        public int ratingScore { get; set; }

        public Rating()
        {

        }
    }
}
