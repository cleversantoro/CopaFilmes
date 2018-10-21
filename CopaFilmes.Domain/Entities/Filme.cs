using System;

namespace CopaFilmes.Domain.Entity
{
    public class Filme
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public double nota { get; set; }

        //public decimal SetAvageRatingDecimal => Convert.ToDecimal(AverageRating.Replace('.', ','));
    }
}
