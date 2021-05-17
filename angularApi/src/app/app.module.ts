import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import {ToastrModule} from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PokemonComponent } from './pokemon/pokemon.component';
import { ListallComponent } from './listcustomers/listall/listall.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { EraseComponent } from './erasecustomer/erase/erase.component';
import { AddComponent } from './addcustomer/add/add.component';
import { UpdatenameComponent } from './updatename/updatename/updatename.component';

@NgModule({
  declarations: [
    AppComponent,
    PokemonComponent,
    ListallComponent,
    EraseComponent,
    AddComponent,
    UpdatenameComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
