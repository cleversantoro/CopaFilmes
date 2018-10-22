import { Injectable } from '@angular/core'
import { Http } from '@angular/http'
import { Router } from '@angular/router'
import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'

import { Filme } from "./filme/filme.model"

@Injectable()
export class FilmesService {

  constructor(private http: Http, private router: Router) { }

  filmescopa(): Observable<Filme[]> {
    return this.http.get('api/Filmes/FilmesCopa')
      .map(response => response.json());
    //.catch(ErrorHandler.handleError)
  }

  gerarCampeonato(filmes:Filme[]): Observable<Filme[]> {
    return this.http.get(`api/Filmes/GerarCampeonato/${filmes}`)
      .map(response => <Filme[]>response.json(),
        this.router.navigate(['/placar'])
      )
  }

}
