import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Filme } from './filme.model'
import { FilmeSelecionado } from '../filmes.model'
import { FilmeService } from './filme.service'


@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html'
})
export class FilmeComponent implements OnInit {
  @Input() filme: Filme
  //@Input() filmes: Filme[] = []
  //@Input() filmesSelecionados: FilmeSelecionado[] = [];
  @Input() qtdSelecionada: number = 0;
  //@Output() add = new EventEmitter()

  constructor(private filmeService : FilmeService) { }

  ngOnInit() { }

  filmes(): any {
    return this.filmeService.filmes;
  }

  quantidade(): number {
    return this.filmeService.filmes.length;
  }

  changeCheck(e: any, filme: Filme) {
    this.qtdSelecionada = this.quantidade();
    if (e.target.checked)
      this.filmeService.checked(filme);
    else
      //this.filmesSelecionados.splice(this.filmesSelecionados.indexOf(filme), 1); //= this.filmesSelecionados.filter(f => f != filme);
      //console.log(this.qtdSelecionada);

    console.log(this.filmeService.filmes.toString());
  }

  checkDisable(filme: Filme) {
    //if (this.filmesSelecionados.find(f => f == filme))
    //return false;

    //console.log(this.qtdSelecionada);
    //console.log(this.filmesSelecionados);

    return this.qtdSelecionada >= 8;

  }

  //emitAddEvent() {
  //  this.add.emit(this.filme);
  //  //this.filmes.push(this.filme);
  //  console.log(this.filmes);
  //}
}
