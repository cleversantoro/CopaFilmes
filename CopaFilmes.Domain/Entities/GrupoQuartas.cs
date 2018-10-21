using System.Collections.Generic;

namespace CopaFilmes.Domain.Entity
{
    public class GrupoQuartas
    {
        public GrupoQuartas()
        {
            Grupo1 = new List<Filme>();
            Grupo2 = new List<Filme>();
        }

        public List<Filme> Grupo1 { get; }
        public List<Filme> Grupo2 { get; }
    }
}