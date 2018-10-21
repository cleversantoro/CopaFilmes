using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Domain.Entity
{
    public class Disputa
    {
        protected Disputa(Filme filme1, Filme filme2)
        {
            if (filme1.nota == filme2.nota)
            {
                var list = new List<Filme> { filme1, filme2 };
                Vencedor = (from p in list orderby p.titulo select p).Take(1).FirstOrDefault();
                Perdedor = (from p in list orderby p.titulo select p).Last();

            }

            Vencedor = filme1.nota > filme2.nota ? filme1 : filme2;
            Perdedor = filme1.nota < filme2.nota ? filme1 : filme2;

        }

        public Filme Vencedor { get; }
        public Filme Perdedor { get; }

        public static Disputa GerarDisputa(Filme filme1, Filme filme2) => new Disputa(filme1, filme2);
    }
}