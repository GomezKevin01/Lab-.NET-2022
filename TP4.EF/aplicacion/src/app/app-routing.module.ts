import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
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
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
