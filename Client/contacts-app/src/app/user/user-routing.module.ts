import { ViewbookingComponent } from './viewbooking/viewbooking.component';
import { InvoiceComponent } from './invoice/invoice.component';
import { BookingComponent } from './booking/booking.component';
import { HomeComponent } from './../user/home/home.component';
import { UserLayoutComponent } from './user-layout.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: '', component: UserLayoutComponent, children: [
      {path: '', component: HomeComponent},
      {path: 'booking/:id', component: BookingComponent},
      {path: 'invoice', component: InvoiceComponent},
      {path: 'viewbooking', component: ViewbookingComponent}


  ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
