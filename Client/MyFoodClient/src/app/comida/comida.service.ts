import { Injectable } from '@angular/core';
import { Comida } from './Comida';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/mergeMap';
import 'rxjs/add/operator/filter';

@Injectable()
export class ComidaService {
    private _Url = 'http://localhost:5000/api/restaurantes/1';
    constructor(private _http: Http) { }
    
    getComidasByRestauranteId(id) : Observable<Comida[]> {
      return this._http.get('http://localhost:5000/api/restaurantes/' + id + '/comidas')
        .map(this.extractData)
        .catch(this.handleError);
    }

    private extractData(response: Response) {
        let body = response.json();
        return body || {};
    }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}