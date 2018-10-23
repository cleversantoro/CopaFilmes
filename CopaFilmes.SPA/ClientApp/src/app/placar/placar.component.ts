import { Component, OnInit, Input } from '@angular/core';
import { Final } from './placar.model'

@Component({
  selector: 'app-placar',
  templateUrl: './placar.component.html'
})
export class PlacarComponent implements OnInit {
  filmes: Final[];

  constructor(
  )
  { }

  ngOnInit() {
    this.filmes = JSON.parse(localStorage.getItem("final"));
  }


}
