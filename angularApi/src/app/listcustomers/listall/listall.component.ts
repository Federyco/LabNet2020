import { Component, OnInit } from '@angular/core';
import {ListcustomersService} from '../../services/listcustomers.service';

@Component({
  selector: 'app-listall',
  templateUrl: './listall.component.html',
  styleUrls: ['./listall.component.scss']
})
export class ListallComponent implements OnInit {

  constructor(private customerService : ListcustomersService) { }
  public clientes: Array<any> =[]

  ngOnInit(): void {
    this.search();
  }

    //esta funcion la ejecuta el html y le pasa el parametro del input
    search(){
      //console.log("entre al search");
      //utilizando mi servicio ingreso a la funcion que envía la url de la api
      //el camino que realiza la información es => input web ----> componente ----> servicio
    this.customerService.selectAllCustomers().subscribe((resp: any) => {
      console.log(resp)
      this.clientes= resp
    })
    
  }
}
