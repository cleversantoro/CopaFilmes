import { Injectable } from '@angular/core'
import { Http } from '@angular/http'

import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'

import { Filme } from "./filme/filme.model"

//import { FILMES_API } from '../app.api'
//import {ErrorHandler} from '../app.error-handler'

@Injectable()
export class FilmesService {

  constructor(private http: Http) { }

  filmescopa(): Observable<Filme[]> {
    return this.http.get('api/Filmes/FilmesCopa')
      .map(response => response.json());
    //.catch(ErrorHandler.handleError)
  }

  gerarCampeonato(): Observable<Filme[]> {
    return this.http.get('api/Filmes/GerarCampeonato')
      .map(response => response.json());
    //.catch(ErrorHandler.handleError)
  }

}
