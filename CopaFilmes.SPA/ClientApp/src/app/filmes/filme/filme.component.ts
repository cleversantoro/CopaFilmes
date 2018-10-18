import { Component, OnInit, Input } from '@angular/core';
//import { trigger, state, style, transition, animate } from '@angular/animations'

import { Filme } from './filme.model'

//import { HttpClient } from '@angular/common/http';

//import { Filme } from '../filmes/filme.model'
//import { FilmesService } from '../filmes/filmes.service'

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html'
})
export class FilmeComponent implements OnInit {

  @Input() filme: Filme

  constructor() { }

  ngOnInit() { }
}
