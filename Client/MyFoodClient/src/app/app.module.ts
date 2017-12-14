import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { routes } from './app.routes';
import { AppComponent } from './app.component';
import { RestauranteComponent } from './restaurante/restaurante.component';
import { HomeComponent } from './home/home.component';
import { RestauranteModule } from './restaurante/restaurante.module';
import { ComidaModule } from './comida/comida.module';

@NgModule({
  declarations: [
    HomeComponent,
    AppComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(routes),
    RestauranteModule, 
    ComidaModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
