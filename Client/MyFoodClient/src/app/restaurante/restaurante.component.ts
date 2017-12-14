import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { Restaurante } from './Restaurante';
import { RestauranteService } from './restaurante.service';

@Component({
  selector: 'app-restaurante',
  templateUrl: './restaurante.component.html',
  styleUrls: ['./restaurante.component.css']
})
export class RestauranteComponent {
  restaurantes: Restaurante[];        
  constructor(private _restauranteService: RestauranteService, private router: Router) {
    this._restauranteService.getRestaurantes()
    .subscribe((data: Restaurante[]) => this.restaurantes = data,
    error => console.log(error));
  }

  public ComidasRestaurante(item) {
    this.router.navigate(['/comidas/' + item.id]);
  }

}
