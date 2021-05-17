import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CustomersI } from '../Models/customersI';

@Injectable({
  providedIn: 'root'
})
export class EraseService {

  constructor(private http:HttpClient) { }


  eraseCustomer(id:string) : Observable<CustomersI>{
    return this.http.delete<CustomersI>(environment.urlAPI + "/"+ id);
  }
}
