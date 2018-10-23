using System.Collections.Generic;

namespace CopaFilmes.Domain.Entity
{
    public class EliminatoriaOitavas
    {
        protected EliminatoriaOitavas(GrupoOitavas oitavas)
        {
            grupoQuartas = new GrupoQuartas();
            PrimeiraDisputa = Disputa.GerarDisputa(oitavas.Grupo1[0], oitavas.Grupo1[1]);
            SegundaDisputa = Disputa.GerarDisputa(oitavas.Grupo2[0], oitavas.Grupo2[1]);
            TerceiraDisputa = Disputa.GerarDisputa(oitavas.Grupo3[0], oitavas.Grupo3[1]);
            QuartaDisputa = Disputa.GerarDisputa(oitavas.Grupo4[0], oitavas.Grupo4[1]);

            grupoQuartas.Grupo1.Add(PrimeiraDisputa.Vencedor);
            grupoQuartas.Grupo1.Add(SegundaDisputa.Vencedor);
            grupoQuartas.Grupo2.Add(TerceiraDisputa.Vencedor);
            grupoQuartas.Grupo2.Add(QuartaDisputa.Vencedor);
        }

        public Disputa PrimeiraDisputa { get; private set; }
        public Disputa SegundaDisputa { get; private set; }
        public Disputa TerceiraDisputa { get; private set; }
        public Disputa QuartaDisputa { get; private set; }
        public GrupoQuartas grupoQuartas { get; set; }


        public static EliminatoriaOitavas GerarFaseEliminatoria(GrupoOitavas oitavas) => new EliminatoriaOitavas(oitavas);
    }
}