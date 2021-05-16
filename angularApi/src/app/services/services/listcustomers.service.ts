import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment} from '../../../environments/environment'
import {Customers} from '../../Models/customers';

@Injectable({
  providedIn: 'root'
})
export class ListcustomersService {
  extension: string = "Customers";
  constructor(private http:HttpClient) { }

  selectAllCustomers(): Observable<Customers[]>{
    console.log("environment: " + environment.urlAPI + this.extension);
    return this.http.get<Customers[]>(environment.urlAPI + this.extension)
  }
}

