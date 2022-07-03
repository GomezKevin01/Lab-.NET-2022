import { EventEmitter, Injectable, Output } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Suppliers } from '../models/Suppliers';


@Injectable({
  providedIn: 'root'
})
export class SuppliersService {

  constructor(private http: HttpClient) { }

  public getSuppliers(): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.get(environment.url + endpoint);
  }

  public getSupplier(id:number): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.get(environment.url + endpoint + '/' + id);
  }

  public postSuppliers(supplierst: Suppliers): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.post(environment.url + endpoint, supplierst);
  }

  public deleteSupplier(suppliers: Suppliers): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.delete(environment.url + endpoint + '/' + suppliers.id);
  }

  public putSupplier(suppliers: Suppliers): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.put(environment.url + endpoint + '/' + suppliers.id, suppliers);
  }

}
