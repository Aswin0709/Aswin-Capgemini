import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {Router} from "@angular/router";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm!: FormGroup;
  submitted: boolean = false;
  invalidLogin: boolean = false;

  constructor(private formBuilder: FormBuilder, private router: Router, ) { }

 

  ngOnInit() {
    

    this.loginForm = this.formBuilder.group({
      email: ['', Validators.required],
      password: ['', Validators.required]
    });

  }
  onSubmit(){
    this.submitted = true;
    if(this.loginForm.invalid){
      return;
    }
    if(this.loginForm.controls['email'].value =="aswin@gmail.com" &&
        this.loginForm.controls['password'].value=="123456"){
          localStorage.setItem("username",this.loginForm.controls['email'].value);
          this.router.navigate(['list-user']);
    }
    else{
      this.invalidLogin = true;
    }
  }
  gohome(){this.router.navigate(['home']);}
}
