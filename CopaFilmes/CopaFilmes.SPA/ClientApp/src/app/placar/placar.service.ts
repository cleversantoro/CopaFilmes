import { Injectable, Input } from '@angular/core'
import { Http } from '@angular/http'
import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'
//import { Score } from "./filme/filme.model"

@Injectable()
export class PlacarService {
  //@Input() final: any;

  constructor(
    private http: Http,
  ) { }

  //filmescopa(): Observable<Filme[]> {
  //  return this.http.get('api/Filmes/FilmesCopa')
  //    .map(response => response.json());
  //  //.catch(ErrorHandler.handleError)
  //}

  //finalcopa(): Observable<Filme[]> {
  //  return this.final;
  //}
  
  //gerarCampeonato(filmes: Filme[]): Observable<Filme[]> {
  //  return this.http
  //    .post(`api/Filmes/GerarCampeonato`, filmes)
  //    .map(response => {
  //      const rt = response.json();
  //      this.final = rt;
  //      return rt
  //    })
  //  //.catch(this.hadleError)
  //}
}
