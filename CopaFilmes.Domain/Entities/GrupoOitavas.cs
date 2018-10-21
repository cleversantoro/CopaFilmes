using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Domain.Entity
{
    public class GrupoOitavas
    {
        protected GrupoOitavas(List<Filme> listaFilmes)
        {
            Grupo1 = new List<Filme>();
            Grupo2 = new List<Filme>();
            Grupo3 = new List<Filme>();
            Grupo4 = new List<Filme>();
            CriarGrupos(listaFilmes);
        }

        private static List<Filme> ListaFilmes;

        public List<Filme> Grupo1 { get; }
        public List<Filme> Grupo2 { get; }
        public List<Filme> Grupo3 { get; }
        public List<Filme> Grupo4 { get; }

        private void CriarGrupos(List<Filme> listaFilmes)
        {
            var lista1 = (from p in listaFilmes orderby p.titulo select p).Take(listaFilmes.Count / 2).ToList();
            var lista2 = (from p in listaFilmes orderby p.titulo descending select p).Take(listaFilmes.Count / 2).ToList();

            Grupo1.Add(lista1[0]);
            Grupo1.Add(lista2[0]);

            Grupo2.Add(lista1[1]);
            Grupo2.Add(lista2[1]);

            Grupo3.Add(lista1[2]);
            Grupo3.Add(lista2[2]);

            Grupo4.Add(lista1[3]);
            Grupo4.Add(lista2[3]);
        }

        public static GrupoOitavas GerarOitavasGrupo(List<Filme> listaFilmes) => new GrupoOitavas(listaFilmes);

    }
}