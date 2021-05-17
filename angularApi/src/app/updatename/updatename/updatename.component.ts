import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CustomersI } from 'src/app/Models/customersI';
import { UpdatecustomerService } from '../../services/updatecustomer.service';

@Component({
  selector: 'app-updatename',
  templateUrl: './updatename.component.html',
  styleUrls: ['./updatename.component.scss']
})
export class UpdatenameComponent implements OnInit {

public form: FormGroup;
constructor(private updateService: UpdatecustomerService, private formbuilder: FormBuilder, private toastr: ToastrService) { }


ngOnInit(): void {
  this.form = this.formbuilder.group({
    customerId: new FormControl('', Validators.required || Validators.minLength(5) || Validators.maxLength(5)),
    companyName: new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(20)),
    contactName: new FormControl('', Validators.required || Validators.minLength(12) || Validators.maxLength(20)),
    contactTitle: new FormControl('', Validators.required || Validators.minLength(2) || Validators.maxLength(20)),
    address: new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(20)),
    city: new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(20)),
    region: new FormControl('', Validators.required || Validators.minLength(2) || Validators.maxLength(20)),
    postalCode: new FormControl('', Validators.required || Validators.minLength(4) || Validators.maxLength(10)),
    country: new FormControl('', Validators.required || Validators.minLength(2) || Validators.maxLength(20)),
    phone: new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(12)),
    fax: new FormControl('', Validators.required || Validators.minLength(8) || Validators.maxLength(12))
   })
}

//esta funcion la ejecuta el html y le pasa el parametro el input
formularioUpdate() {
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
  this.updateService.updateClientName(nuevoCliente).subscribe({
   next: data => {
      this.toastr.success("Nuevo cliente Agregado Exitosamente", 'Correcto!');
    },
    error: error => {
      this.toastr.error('Ocurrió un error, revise sus datos!', 'Error!');
    }
  });
}
}
