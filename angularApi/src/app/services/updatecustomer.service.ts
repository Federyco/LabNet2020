import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {environment} from '../../environments/environment';
import { CustomersI } from '../Models/customersI';

@Injectable({
  providedIn: 'root'
})
export class UpdatecustomerService {

  

  constructor(private http:HttpClient) { }
 

  updateClientName(id: string, name:string) : Observable<CustomersI[]>{
    let direccion = environment.urlAPI + "Customers";
    console.log("estoy en el update: " + id +" "+ name)
    return this.http.put<CustomersI[]>(direccion, id+"?contactName="+ name);
  }

}
