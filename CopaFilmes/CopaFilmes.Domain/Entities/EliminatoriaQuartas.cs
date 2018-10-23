using System.Collections.Generic;

namespace CopaFilmes.Domain.Entity
{
    public class EliminatoriaQuartas
    {
        protected EliminatoriaQuartas(GrupoQuartas quartas)
        {
            grupoSemiFinal = new SemiFinal();

            PrimeiraDisputa = Disputa.GerarDisputa(quartas.Grupo1[0], quartas.Grupo1[1]);
            SegundaDisputa = Disputa.GerarDisputa(quartas.Grupo2[0], quartas.Grupo2[1]);

            grupoSemiFinal.Grupo1.Add(PrimeiraDisputa.Vencedor);
            grupoSemiFinal.Grupo1.Add(SegundaDisputa.Vencedor);
        }

        public Disputa PrimeiraDisputa { get; private set; }
        public Disputa SegundaDisputa { get; private set; }
        public Disputa TerceiraDisputa { get; private set; }
        public Disputa QuartaDisputa { get; private set; }       
        public SemiFinal grupoSemiFinal { get; set; }

        public static EliminatoriaQuartas GerarFaseEliminatoria(GrupoQuartas quartas) => new EliminatoriaQuartas(quartas);
    }
}