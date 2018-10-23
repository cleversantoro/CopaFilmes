import { Component, OnInit, Input } from '@angular/core';
import { Filme } from '../../filmes/filme/filme.model'
//import { PlacarService } from '../../placar/placar.service'

@Component({
  selector: 'app-score',
  templateUrl: './score.component.html'
})
export class ScoreComponent implements OnInit {
  filmes: Filme[];

  constructor(
    //private placarService: PlacarService
  )
  { }

  ngOnInit() {
    //this.filmesService.finalcopa().subscribe(final => (this.filmes = final));
  }
}
