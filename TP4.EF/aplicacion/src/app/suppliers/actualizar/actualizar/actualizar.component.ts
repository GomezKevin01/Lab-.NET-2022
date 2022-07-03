import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Suppliers } from '../../models/Suppliers';
import { SuppliersService } from '../../services/suppliers.service';

@Component({
  selector: 'app-actualizar',
  templateUrl: './actualizar.component.html',
  styleUrls: ['./actualizar.component.scss']
})
export class ActualizarComponent implements OnInit {

  form!: FormGroup;
  suppliers: Suppliers = new Suppliers;

  constructor(private activatedRoute: ActivatedRoute, private router: Router, private fb: FormBuilder, private supplierService: SuppliersService) { }


  ngOnInit(): void {
    this.form = this.fb.group({
      nombre: ['', Validators.required],
      pais: ['', Validators.required]
    });
    this.cargarDatos();
  }

  cargarDatos(): void {
    this.activatedRoute.params.subscribe(
      obtenerId => {
        let id = obtenerId['id'];
        if (id) {
          this.supplierService.getSupplier(id).subscribe(
            obtenerSupplier => this.suppliers = obtenerSupplier
          );
        }
      }
    )
  }

  modificar() {
    this.suppliers = this.form.value;
    this.activatedRoute.params.subscribe(
      obtenerId => {
        this.suppliers.id = obtenerId['id']
      });
    this.supplierService.putSupplier(this.suppliers).subscribe({
      next: (resp) => {
        alert("Proveedor modificado correctamente!!!");
        this.form.reset();
        this.router.navigate(['']);
      },
      error: (error) => {
        alert("Complete todos los campos!!!");
      }
    });
  }
}
