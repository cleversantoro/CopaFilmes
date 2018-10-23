import { Injectable, Input } from '@angular/core'
import { Http } from '@angular/http'
import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'
import { Filme } from "./filme/filme.model"
import { Router } from '@angular/router'

@Injectable()
export class FilmesService {
  @Input() final: any;
  @Input() qtdeSelecionada: number = 0;

  constructor(
    private http: Http,
    private route: Router

  ) { }

  filmescopa(): Observable<Filme[]> {
    return this.http.get('api/Filmes/FilmesCopa')
      .map(response => response.json());
    //.catch(ErrorHandler.handleError)
  }

  finalcopa(): Observable<Filme[]> {
    return this.final;
  }
  
  gerarCampeonato(filmes: Filme[]): Observable<Filme[]> {
    return this.http
      .post(`api/Filmes/GerarCampeonato`, filmes)
      .map(response => {
        const rt = response.json();
        this.final = rt;

        this.route.navigate(['/placar'],{ queryParams: this.final }); 

        return rt
      })
    //.catch(this.hadleError)

  }
}
