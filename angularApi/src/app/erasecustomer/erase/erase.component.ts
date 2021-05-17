import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import {EraseService} from '../../services/erase.service';

import {ToastrService} from 'ngx-toastr';
import { analyzeAndValidateNgModules } from '@angular/compiler';
import { stringify } from '@angular/compiler/src/util';


@Component({
  selector: 'app-erase',
  templateUrl: './erase.component.html',
  styleUrls: ['./erase.component.scss']
})
export class EraseComponent implements OnInit {

  idInput :string;
  formularioErase = new FormGroup({
    customerId: new FormControl('', Validators.required || Validators.minLength(5) || Validators.maxLength(5))
  })

  constructor(private eraseService : EraseService, private toastr:ToastrService) { }

  ngOnInit(): void {
  }

  Delete()
  {
    var idInput = this.formularioErase.get('customerId').value;

      if(idInput == null || idInput == ' ' || idInput == '')
      {
        this.toastr.error('El campo Customer ID no puede estar vacio.', 'Error!');
      }
      if(idInput.length > 5 || idInput.length < 5)
      {
        this.toastr.error('El Customer ID ingresado, debe ser de 5  digitos', 'Error!');
      }
      else
      {
      this.eraseService.eraseCustomer(idInput).subscribe({
        next: data => {
          this.toastr.success("El Customer ID " + idInput + " ha sido borrado", 'Correcto!');
        },
        error: error => {
          this.toastr.error('El Customer ID ingresado no existe!', 'Error!');
        }
    });

      }
    }
}
