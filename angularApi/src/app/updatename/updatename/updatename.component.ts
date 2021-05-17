import { Component, OnInit } from '@angular/core';
import { CustomersI } from 'src/app/Models/customersI';
import {UpdatecustomerService} from '../../services/updatecustomer.service';

@Component({
  selector: 'app-updatename',
  templateUrl: './updatename.component.html',
  styleUrls: ['./updatename.component.scss']
})
export class UpdatenameComponent implements OnInit {
  public actualizar : CustomersI ={
    id :'',
companyName :'',
contactName :'',
contactTitle :'',
address :'',
city :'',
region :'',
postalCode :'',
country :'',
contactPhone :'',
fax :''
  }
id = this.actualizar.id;
newname = this.actualizar.contactName;


  constructor(private updateService:UpdatecustomerService) { }

 
  ngOnInit(): void {
  }

  //esta funcion la ejecuta el html y le pasa el parametro el input
  update(){
    //console.log("entre al search");
    //console.log("me pasó el name: " + this.name);
    //utilizando mi servicio ingreso a la funcion que envía la url de la api
    //el camino que realiza la información es => input web ----> componente ----> servicio
    this.updateService.updateClientName(this.id, this.newname).subscribe(data =>{
      console.log(data)
    })
  }


}
