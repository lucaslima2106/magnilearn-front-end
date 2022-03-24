import { Component, OnInit } from '@angular/core';
import * as router from '../services/routeParam';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  userId: number = 0;

  constructor() { }

  ngOnInit(): void {
    this.userId = router.default();
    console.log(this.userId);
  }

}
