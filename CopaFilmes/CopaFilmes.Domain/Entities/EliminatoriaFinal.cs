using System.Collections.Generic;

namespace CopaFilmes.Domain.Entity
{
    public class EliminatoriaFinal
    {
        protected EliminatoriaFinal(SemiFinal semifinal)
        {
            final = new Final();

            DisputaFinal = Disputa.GerarDisputa(semifinal.Grupo1[0], semifinal.Grupo1[1]);
            final.Campeao = DisputaFinal.Vencedor;
            final.Vice = DisputaFinal.Perdedor;
            final.GrupoFinal.Add(final.Campeao);
            final.GrupoFinal.Add(final.Vice);

        }

        public Disputa DisputaFinal { get; private set; }

        public Final final { get; set; }

        public static EliminatoriaFinal GerarFinal(SemiFinal semifinal) => new EliminatoriaFinal(semifinal);
    }
}