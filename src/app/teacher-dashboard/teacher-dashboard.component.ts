import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-teacher-dashboard',
  templateUrl: './teacher-dashboard.component.html',
  styleUrls: ['./teacher-dashboard.component.css']
})
export class TeacherDashboardComponent implements OnInit {

  public studentsOverallPerformance: any[] = [];
  public mostLearnedWords: any[] = [];
  public bestRankedExercises: any[] = [];
  public usersGrades: any[] = [];

  constructor(private data: DataService) { }

  ngOnInit(): void {

    this.data.getStudentsOverallPerformance().subscribe(
      (response: any) => {
        this.studentsOverallPerformance = response;
      }
    );

    this.data.getMostLearnedWords().subscribe(
      (response: any) => {
        this.mostLearnedWords = response;
      }
    );

    this.data.getBestRankedExercises().subscribe(
      (response: any) => {
        this.bestRankedExercises = response;
      }
    );

    this.data.getUsersGrades().subscribe(
      (response: any) => {
        this.usersGrades = response;
      }
    );
    
  }
}