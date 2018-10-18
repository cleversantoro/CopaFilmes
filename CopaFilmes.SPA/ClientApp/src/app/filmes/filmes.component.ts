import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Filme } from './filme/filme.model'
import { FilmesService } from '../filmes/filmes.service'

import "rxjs/add/operator/switchMap";
import "rxjs/add/operator/do";
import "rxjs/add/operator/debounceTime";
import "rxjs/add/operator/distinctUntilChanged";
import "rxjs/add/operator/catch";
import "rxjs/add/observable/from";
import { Observable } from "rxjs/Observable";


@Component({
  selector: 'app-filmes',
  templateUrl: './filmes.component.html'
})
export class FilmesComponent {
  filmes: Filme[];

  constructor(
    private filmesService: FilmesService
    //private fb: FormBuilder
  ) { }

  ngOnInit() {

    this.filmesService.filmes().subscribe(filmes => (this.filmes = filmes));
  }

}
