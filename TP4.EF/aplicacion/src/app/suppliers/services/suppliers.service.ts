import { Injectable } from '@angular/core';
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

  public postSuppliers(request: Suppliers): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.post(environment.url + endpoint, request);
  }

  public deleteSupplier(suppliers: Suppliers): Observable<any> {
    let endpoint = 'api/Suppliers';
    return this.http.delete(environment.url + endpoint + '/' + suppliers.id);  
  }

}
