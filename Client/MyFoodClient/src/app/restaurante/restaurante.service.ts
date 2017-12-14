import { Injectable } from '@angular/core';
import { Restaurante } from './Restaurante';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/mergeMap';
import 'rxjs/add/operator/filter';

@Injectable()
export class RestauranteService {
    private _Url = 'http://localhost:5000/api/restaurantes/1';
    constructor(private _http: Http) { }
    
    getRestauranteById(id: number): Observable<Restaurante> {
        return this._http.get(this._Url)
            .map((response: Response) => <Restaurante>response.json())
            .catch(this.handleError);
    }

    getRestaurantes():Observable<Restaurante[]> {
      return this._http.get('http://localhost:5000/api/restaurantes')
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