import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Suppliers } from '../models/Suppliers';
import { SuppliersService } from '../services/suppliers.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listado',
  templateUrl: './listado.component.html',
  styleUrls: ['./listado.component.scss']
})
export class ListadoComponent implements OnInit {
  suppliersList: Suppliers[] = [];

  constructor(private router:Router,private supplierService: SuppliersService) { }

  ngOnInit(): void {
    this.supplierService.getSuppliers().subscribe(resp => {
      this.suppliersList = resp
    });
  }

  eliminar(suppliers: Suppliers) {
    this.supplierService.deleteSupplier(suppliers).subscribe({
      next: (res) => {
        alert('Seguro que desea eliminar al proveedor seleccionado?');
        window.location.reload();//refresca la página     
      },
      error: (error) =>{
        alert('El proveedor no puede ser eliminado!!!')
      }
    });
    }

}
