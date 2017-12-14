import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { ActivatedRoute } from '@angular/router';
import { Comida } from './Comida';
import { ComidaService } from './comida.service'

@Component({
  selector: 'app-comida',
  templateUrl: './comida.component.html',
  styleUrls: ['./comida.component.css']
})
export class ComidaComponent {
  comidas: Comida[];
  idRestaurante: any;
  constructor(private route: ActivatedRoute, private _comidaService: ComidaService) {
    this.route.params.subscribe(params => {
      this.idRestaurante = params['id'];
    });
    if (this.idRestaurante != null) {
      this._comidaService.getComidasByRestauranteId(this.idRestaurante)
      .subscribe((data: Comida[]) => this.comidas = data,
      error => console.log(error));
    }
  }
}
