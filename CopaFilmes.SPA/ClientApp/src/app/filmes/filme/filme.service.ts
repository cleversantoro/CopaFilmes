import { Injectable } from '@angular/core'
import { Http } from '@angular/http'

import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'

import { FilmeSelecionado } from "../filmes.model"
import { Filme } from "./filme.model"

@Injectable()
export class FilmeService {
  filmes: FilmeSelecionado[] = []
  qtdSelecionada: number = 0;

  checked(filme: Filme) {
    this.filmes.push(new FilmeSelecionado(filme, this.qtdSelecionada))
  }

  unchecked(filme: FilmeSelecionado) {
    this.filmes.splice(this.filmes.indexOf(filme),1)
  }

}
