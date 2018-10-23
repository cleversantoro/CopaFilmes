import { Component, OnInit, Input } from '@angular/core';
import { Filme } from '../../filmes/filme/filme.model'
import { Final } from '../placar.model';
//import { PlacarService } from '../../placar/placar.service'

@Component({
  selector: 'app-score',
  templateUrl: './score.component.html'
})
export class ScoreComponent implements OnInit {
  @Input() filmes: Final;

  constructor(
  ) { }

  ngOnInit() {
  }
}
