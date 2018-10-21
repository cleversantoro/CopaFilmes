using System.Collections.Generic;

namespace CopaFilmes.Domain.Entity
{
    public class Final
    {
        public Final()
        {
            Campeao = new Filme();
            Vice = new Filme();
            GrupoFinal = new List<Filme>();
        }

        public Filme Campeao { get; set; }
        public Filme Vice { get; set; }
        public List<Filme> GrupoFinal { get; set; }
       
    }
}