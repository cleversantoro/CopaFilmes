import { Component, OnInit, Input } from '@angular/core';
//import { trigger, state, style, transition, animate } from '@angular/animations'

import { Filme } from '../filmes/filme/filme.model'

//import { HttpClient } from '@angular/common/http';

//import { Filme } from '../filmes/filme.model'
//import { FilmesService } from '../filmes/filmes.service'

@Component({
  selector: 'app-placar',
  templateUrl: './placar.component.html'
})
export class PlacarComponent implements OnInit {

  filmes: Filme[];

  constructor() { }

  ngOnInit() { }
}
