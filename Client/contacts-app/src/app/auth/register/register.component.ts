import { AuthService } from './../services/auth.service';
import { NgForm } from '@angular/forms';
import { Component } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
    constructor(private authService:AuthService){

    }
    save(data:NgForm){
        // console.log(data.value);
        this.authService.register(data.value).subscribe(res=>
            console.log(res)
            );}
}
