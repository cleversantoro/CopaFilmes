import { Component, OnInit, Input } from '@angular/core';
//import { trigger, state, style, transition, animate } from '@angular/animations'
import { Filme } from '../filmes/filme/filme.model'
//import { HttpClient } from '@angular/common/http';
//import { Filme } from '../filmes/filme.model'
import { FilmesService } from '../filmes/filmes.service'
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-placar',
  templateUrl: './placar.component.html'
})
export class PlacarComponent implements OnInit {
  filmes: Filme[];

  constructor(
    private filmesService: FilmesService,
    private route: ActivatedRoute
  )
  { }

  ngOnInit() {
    //this.filmesService.finalcopa().subscribe(final => (this.filmes = final));

    let final = this.route
      .queryParamMap
      .map(params => params.get('atributo') || 'None');

    
  }
}
