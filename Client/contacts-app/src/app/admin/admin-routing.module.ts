import { AddroomComponent } from './addroom/addroom.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminLayoutComponent } from './admin-layout.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path: '', component: AdminLayoutComponent, children:[
    {path: 'home', component: HomeComponent},
    {path: 'addroom', component: AddroomComponent},

 ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
