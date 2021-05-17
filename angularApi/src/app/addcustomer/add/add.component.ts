import { Component, OnInit } from '@angular/core';
import {AddcustomerService} from '../../services/addcustomer.service';
import {CustomersI} from '../../Models/customersI';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})
export class AddComponent implements OnInit {


public form:FormGroup;
constructor(private addService: AddcustomerService, private formbuilder:FormBuilder, private toastr:ToastrService) { }



  ngOnInit(): void {
    this.form = this.formbuilder.group({
      customerId: new FormControl('', Validators.required || Validators.minLength(5) || Validators.maxLength(5)),
      companyName: new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(20)),
      contactName: new FormControl('', Validators.required || Validators.minLength(12) || Validators.maxLength(20)),
      contactTitle: new FormControl('', Validators.required || Validators.minLength(2) || Validators.maxLength(20)),
      address:new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(20)),
      city: new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(20)),
      region:new FormControl('', Validators.required || Validators.minLength(2) || Validators.maxLength(20)),
      postalCode: new FormControl('', Validators.required || Validators.minLength(4) || Validators.maxLength(10)),
      country:new FormControl('', Validators.required || Validators.minLength(2) || Validators.maxLength(20)),
      phone:new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(12)),
      fax:new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(12))

    })
  }

  formularioAdd(){
     var nuevoCliente = new CustomersI();
     nuevoCliente.id = this.form.get('customerId').value,
     nuevoCliente.companyName = this.form.get('companyName').value
     nuevoCliente.contactName = this.form.get('contactName').value
     nuevoCliente.contactTitle = this.form.get('contactTitle').value
     nuevoCliente.address = this.form.get('address').value
     nuevoCliente.city = this.form.get('city').value
     nuevoCliente.region = this.form.get('region').value
     nuevoCliente.postalCode = this.form.get('postalCode').value
     nuevoCliente.country = this.form.get('country').value
     nuevoCliente.contactPhone = this.form.get('phone').value
     nuevoCliente.fax = this.form.get('fax').value
     this.addService.addNewCustomer(nuevoCliente).subscribe({
      next: data => {
        this.toastr.success("Nuevo cliente Agregado Exitosamente", 'Correcto!');
      },
      error: error => {
        this.toastr.error('Ocurrió un error, revise sus datos!', 'Error!');
      }
  });
  }
}
