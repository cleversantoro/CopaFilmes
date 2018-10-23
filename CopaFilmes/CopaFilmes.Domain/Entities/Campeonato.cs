using System.Collections.Generic;

namespace CopaFilmes.Domain.Entity
{
    public class Campeonato
    {
        protected Campeonato(List<Filme> Filmes)
        {
            grupoOitavas = GrupoOitavas.GerarOitavasGrupo(Filmes);
            grupoQuartas = EliminatoriaOitavas.GerarFaseEliminatoria(grupoOitavas).grupoQuartas;
            semiFinal = EliminatoriaQuartas.GerarFaseEliminatoria(grupoQuartas).grupoSemiFinal;
            final = EliminatoriaFinal.GerarFinal(semiFinal).final;
        }

        public GrupoOitavas grupoOitavas { get; set; }
        public EliminatoriaOitavas eliminatoriaOitavas { get; set; }
        public GrupoQuartas grupoQuartas { get; set; }
        public SemiFinal semiFinal { get; set; }
        public Final final { get; set; }

        public static Campeonato RealizarCampeonato(List<Filme> Filmes) => new Campeonato(Filmes);

    }
}
