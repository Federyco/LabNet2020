import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment} from '../../environments/environment'
import {CustomersI} from '../Models/customersI';

@Injectable({
  providedIn: 'root'
})
export class ListcustomersService {
  constructor(private http:HttpClient) { }

  selectAllCustomers(): Observable<CustomersI[]>{
    return this.http.get<CustomersI[]>(environment.urlAPI)
  }
}

