import { Routes } from '@angular/router';
import { RestauranteComponent } from './restaurante/restaurante.component';
import { ComidaComponent } from './comida/comida.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'restaurantes', component: RestauranteComponent },
  { path: 'comidas/:id', component: ComidaComponent }
];
