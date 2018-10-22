import { Component, Input } from '@angular/core';

import { Filme } from './filme/filme.model'
import { FilmesService } from '../filmes/filmes.service'
import { FilmeService } from './filme/filme.service'

import "rxjs/add/operator/switchMap";
import "rxjs/add/operator/do";
import "rxjs/add/operator/debounceTime";
import "rxjs/add/operator/distinctUntilChanged";
import "rxjs/add/operator/catch";
import "rxjs/add/observable/from";
import { Observable } from "rxjs/Observable";
import { forEach } from '@angular/router/src/utils/collection';
import { FilmeSelecionado } from './filmes.model';


@Component({
  selector: 'app-filmes',
  templateUrl: './filmes.component.html'
})
export class FilmesComponent {
  filmes: Filme[];

  @Input() filmesSelecionados: FilmeSelecionado[];
  @Input() qtdSelecionada: number = 0;

  constructor(private filmesService: FilmesService,private filmeservice: FilmeService) { }

  ngOnInit() {
    this.filmesService.filmescopa().subscribe(filmes => (this.filmes = filmes));
  }

  gerarCampeonato() {
    this.filmesSelecionados = this.filmeservice.filmes;
    let filmes: Filme[] = [];
    for (var i = 0; i < this.filmesSelecionados.length ; i++) {
      filmes.push(this.filmesSelecionados[i].Filme)
    }
    this.filmesService.gerarCampeonato(filmes).subscribe(filmes => (this.filmes = filmes));   
  }

  
  //  this.selecaoService.qtdeSelecionados.subscribe(qtde => {
  //  this.desabilitado = (qtde >= 8 && !this.checked);
  //console.log(`filme: ${this.filme.titulo} qtde: ${qtde} checked: ${this.checked}`);
  //})

}
