using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
//using CopaFilmes.SPA.Models;
using Newtonsoft.Json;
using CopaFilmes.Domain.Entity;
using System.Threading.Tasks;
using System.Net.Http;
using System;

namespace CopaFilmes.SPA.Controllers
{
    [Route("api/[controller]")]
    public class FilmesController : Controller
    {
        private static string[] Filmes = new[]
        {
            "{\"id\":\"tt3606756\",\"titulo\":\"Os Incríveis 2\",\"ano\":2018,\"nota\":8.5}",
            "{\"id\":\"tt4881806\",\"titulo\":\"Jurassic World: Reino Ameaçado\",\"ano\":2018,\"nota\":6.7}",
            "{\"id\":\"tt5164214\",\"titulo\":\"Oito Mulheres e um Segredo\",\"ano\":2018,\"nota\":6.3}",
            "{\"id\":\"tt7784604\",\"titulo\":\"Hereditário\",\"ano\":2018,\"nota\":7.8}",
            "{\"id\":\"tt4154756\",\"titulo\":\"Vingadores: Guerra Infinita\",\"ano\":2018,\"nota\":8.8}",
            "{\"id\":\"tt5463162\",\"titulo\":\"Deadpool 2\",\"ano\":2018,\"nota\":8.1}",
            "{\"id\":\"tt3778644\",\"titulo\":\"Han Solo: Uma História Star Wars\",\"ano\":2018,\"nota\":7.2}",
            "{\"id\":\"tt3501632\",\"titulo\":\"Thor: Ragnarok\",\"ano\":2017,\"nota\":7.9}",
            "{\"id\":\"tt2854926\",\"titulo\":\"Te Peguei!\",\"ano\":2018,\"nota\":7.1}",
            "{\"id\":\"tt0317705\",\"titulo\":\"Os Incríveis\",\"ano\":2004,\"nota\":8.0}",
            "{\"id\":\"tt3799232\",\"titulo\":\"A Barraca do Beijo\",\"ano\":2018,\"nota\":6.4}",
            "{\"id\":\"tt1365519\",\"titulo\":\"Tomb Raider: A Origem\",\"ano\":2018,\"nota\":6.5}",
            "{\"id\":\"tt1825683\",\"titulo\":\"Pantera Negra\",\"ano\":2018,\"nota\":7.5}",
            "{\"id\":\"tt5834262\",\"titulo\":\"Hotel Artemis\",\"ano\":2018,\"nota\":6.3}",
            "{\"id\":\"tt7690670\",\"titulo\":\"Superfly\",\"ano\":2018,\"nota\":5.1}",
            "{\"id\":\"tt6499752\",\"titulo\":\"Upgrade\",\"ano\":2018,\"nota\":7.8}"
        };
        private static string[] selecao = new[]
{
            "{\"id\":\"tt3606756\",\"titulo\":\"Os Incríveis 2\",\"ano\":2018,\"nota\":8.5}",
            "{\"id\":\"tt4881806\",\"titulo\":\"Jurassic World: Reino Ameaçado\",\"ano\":2018,\"nota\":6.7}",
            "{\"id\":\"tt5164214\",\"titulo\":\"Oito Mulheres e um Segredo\",\"ano\":2018,\"nota\":6.3}",
            "{\"id\":\"tt7784604\",\"titulo\":\"Hereditário\",\"ano\":2018,\"nota\":7.8}",
            "{\"id\":\"tt4154756\",\"titulo\":\"Vingadores: Guerra Infinita\",\"ano\":2018,\"nota\":8.8}",
            "{\"id\":\"tt5463162\",\"titulo\":\"Deadpool 2\",\"ano\":2018,\"nota\":8.1}",
            "{\"id\":\"tt3778644\",\"titulo\":\"Han Solo: Uma História Star Wars\",\"ano\":2018,\"nota\":7.2}",
            "{\"id\":\"tt3501632\",\"titulo\":\"Thor: Ragnarok\",\"ano\":2017,\"nota\":7.9}",
        };


        [HttpGet("[action]")]
        public async Task<IEnumerable<Filme>> FilmesCopa()
        //public IEnumerable<Filme> FilmesCopa()
        {
            //var filmes = new List<Filme>();
            //foreach (var item in Filmes)
            //{
            //    Filme film = JsonConvert.DeserializeObject<Filme>(item);
            //    filmes.Add(film);
            //}
            //return filmes;

            HttpClient client = new HttpClient();
            try
            {
                string url = "http://copafilmes.azurewebsites.net/api/filmes";
                var response = await client.GetStringAsync(url);
                var Filmes = JsonConvert.DeserializeObject<List<Filme>>(response);
                return Filmes;
            }
            catch
            {
                //throw ex;
                return null;
            }

        }

        [HttpPost("GerarCampeonato")]
        public IEnumerable<Filme> GerarCampeonato([FromBody] List<Filme> filmes)
        {
            Campeonato campeonato = Campeonato.RealizarCampeonato(filmes);
            GrupoOitavas oitavas =  campeonato.grupoOitavas;
            GrupoQuartas quartas = campeonato.grupoQuartas;
            SemiFinal semifinal = campeonato.semiFinal;
            Final final= campeonato.final;

            return final.GrupoFinal;
        }

    }
}
