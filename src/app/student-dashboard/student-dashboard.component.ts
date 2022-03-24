import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';
import * as router from '../services/routeParam';

@Component({
  selector: 'app-student-dashboard',
  templateUrl: './student-dashboard.component.html',
  styleUrls: ['./student-dashboard.component.css']
})
export class StudentDashboardComponent implements OnInit {

  public numberOfExercises: any;
  public userPerformance: any[] = [];
  public userLearnedVocabulary: any[] = [];
  public userProgress: any;
  public userGrade: any;
  public userId: number = 0;

  constructor(private data: DataService) { }

  ngOnInit(): void {
    this.userId = router.default();

    this.data.getUserEffort(this.userId).subscribe(
      (response: any) => {
        this.numberOfExercises = response.numberOfExercises;
      }
    );

    this.data.getUserPerformance(this.userId).subscribe(
      (response: any) => {
        this.userPerformance = response;
      }
    );

    this.data.getUserLearnedVocabulary(this.userId).subscribe(
      (response: any) => {
        this.userLearnedVocabulary = response;
      }
    );

    this.data.getUserProgress(this.userId).subscribe(
      (response: any) => {
        this.userProgress = response;
      }
    );

    this.data.getUserGrade(this.userId).subscribe(
      (response: any) => {
        this.userGrade = response;
      }
    );
  }
}