import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { CustomersI } from '../Models/customersI';
import {environment} from '../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AddcustomerService {

  constructor(private http:HttpClient) { }

  
  addNewCustomer(Customers: CustomersI){
    return this.http.post(environment.urlAPI, Customers );
  }
}
