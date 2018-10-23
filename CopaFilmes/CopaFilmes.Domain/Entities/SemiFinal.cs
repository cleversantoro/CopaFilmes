using System.Collections.Generic;

namespace CopaFilmes.Domain.Entity
{
    public class SemiFinal
    {
        public SemiFinal()
        {
            Grupo1 = new List<Filme>();
        }

        public List<Filme> Grupo1 { get; }

    }
}