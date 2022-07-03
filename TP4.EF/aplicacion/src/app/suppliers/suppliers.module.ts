import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListadoComponent } from './listado/listado.component';
import { CrearComponent } from './crear/crear/crear.component';
import { AppRoutingModule } from '../app-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ActualizarComponent } from './actualizar/actualizar/actualizar.component';

@NgModule({
  declarations: [
    ListadoComponent,
    CrearComponent,
    ActualizarComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
  ]
})
export class SuppliersModule { }
