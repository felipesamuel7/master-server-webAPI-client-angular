import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComidaComponent } from './comida.component';
import { ComidaService } from './comida.service';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  declarations: [ComidaComponent],
  providers: [ComidaService]
})
export class ComidaModule { }