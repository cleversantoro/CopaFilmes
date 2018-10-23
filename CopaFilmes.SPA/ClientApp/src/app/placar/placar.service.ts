import { Injectable, Input } from '@angular/core'
import { Http } from '@angular/http'
import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'

@Injectable()
export class PlacarService {

  constructor(
    private http: Http,
  ) { }

}
