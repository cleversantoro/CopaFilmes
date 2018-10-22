import { Filme } from './filme/filme.model'

export class FilmeSelecionado {

  constructor(public Filme: Filme, public quantity: number = 1) { }

  value(): number {
    let qtde;
    return qtde + this.quantity;
  }

}
