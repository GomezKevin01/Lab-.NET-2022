import { Component, OnInit } from '@angular/core';
import { Suppliers } from '../../models/Suppliers';
import { SuppliersService } from '../../services/suppliers.service';
import { Router } from '@angular/router';
import {
  FormBuilder,
  FormGroup,
  Validators
} from '@angular/forms';

@Component({
  selector: 'app-crear',
  templateUrl: './crear.component.html',
  styleUrls: ['./crear.component.scss']
})
export class CrearComponent implements OnInit {
  form!: FormGroup;

  constructor(private router : Router,private fb: FormBuilder, private supplierService: SuppliersService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      nombre: ['', Validators.required],
      pais: ['', Validators.required]
    });
  }


  guardar() {
    var suppliers = new Suppliers();
    suppliers.nombre = this.form.get('nombre')?.value;
    suppliers.pais = this.form.get('pais')?.value;
    this.supplierService.postSuppliers(suppliers).subscribe({
      next: (resp)=>{
        alert("Proveedor añadido correctamente!!!");
        this.form.reset();  
        this.router.navigate(['']); 
      },
      error: (error)=>{
        alert("Complete todos los campos!!!");       
      }
    });       

  }
}
