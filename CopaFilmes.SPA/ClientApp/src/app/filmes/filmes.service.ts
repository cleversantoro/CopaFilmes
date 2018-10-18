import { Injectable } from '@angular/core'
import { Http } from '@angular/http'

import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'

import { Filme } from "./filme/filme.model"
//import {MenuItem} from '../restaurant-detail/menu-item/menu-item.model'

import { FILMES_API } from '../app.api'
//import {ErrorHandler} from '../app.error-handler'

@Injectable()
export class FilmesService {

  constructor(private http: Http) { }

  filmes(search?: string): Observable<Filme[]> {
    return this.http.get(`${FILMES_API}/filmes`, { params: { q: search } })
      .map(response => response.json())
    //.catch(ErrorHandler.handleError)
  }
}
