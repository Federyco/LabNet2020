import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from './addcustomer/add/add.component';
import { AppComponent } from './app.component';
import { EraseComponent } from './erasecustomer/erase/erase.component';
import { ListallComponent } from './listcustomers/listall/listall.component';
import { UpdatecustomerService } from './services/updatecustomer.service';
import { UpdatenameComponent } from './updatename/updatename/updatename.component';

const routes: Routes = [
  {path:'home', component: AppComponent},
  {path:'newcustomer', component: AddComponent},
  {path:'listcustomer', component: ListallComponent},
  {path:'updatecustomer', component: UpdatenameComponent},
  {path:'deletecustomer', component: EraseComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
