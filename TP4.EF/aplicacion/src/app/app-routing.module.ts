import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ActualizarComponent } from './suppliers/actualizar/actualizar/actualizar.component';
import { CrearComponent } from './suppliers/crear/crear/crear.component';
import { ListadoComponent } from './suppliers/listado/listado.component';

const routes: Routes = [
  {
    path:'',
    component:ListadoComponent  
  },
  {
    path:'crear',
    component:CrearComponent
  },
  {
    path:'modificar/:id',
    component:ActualizarComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

