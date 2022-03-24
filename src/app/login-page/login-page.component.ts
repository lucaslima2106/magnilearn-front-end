import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent{
  userId: number = 0;

  constructor(private route: ActivatedRoute) {}

  login() {
    switch (this.userId) {
      case 0:
        window.location.href = "/dashboard/teacher/" + this.userId;
        break;
      case 1:
      case 2:
        window.location.href = "/dashboard/student/" + this.userId;
        break;
      default:
        window.location.href = "/dashboard/teacher/" + this.userId;
        break;
    }
  }

}
