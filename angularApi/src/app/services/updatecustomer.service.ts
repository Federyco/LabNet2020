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
 

  updateClientName(Customers:CustomersI){
    return this.http.put(environment.urlAPI, Customers);
  }

}
