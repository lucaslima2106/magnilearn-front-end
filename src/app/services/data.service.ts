import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})

export class DataService {
    baseURL: string;

    constructor(private http: HttpClient) {
        this.baseURL = "http://localhost:3000/";
        //https://localhost:7085/magnilearn/dashboard/student/1
    }

    //User services
    getUserEffort(userId: number) {
        return this.http.get<any>('https://localhost:7085/magnilearn/dashboard/student/' + userId + '/effort');
    }

    getUserPerformance(userId: number) {
        return this.http.get<any[]>('https://localhost:7085/magnilearn/dashboard/student/' + userId + '/performance');
    }

    getUserLearnedVocabulary(userId: number) {
        return this.http.get<any[]>('https://localhost:7085/magnilearn/dashboard/student/' + userId + '/learnedVocabulary');
    }

    getUserProgress(userId: number) {
        return this.http.get<any>('https://localhost:7085/magnilearn/dashboard/student/' + userId + '/progress');
    }

    getUserGrade(userId: number) {
        return this.http.get<any[]>('https://localhost:7085/magnilearn/dashboard/student/' + userId + '/grade');
    }

    //Teacher services
    getStudentsOverallPerformance() {
        return this.http.get<any[]>('https://localhost:7085/magnilearn/dashboard/teacher/students-overall-performance');
    }
    
    getMostLearnedWords() {
        return this.http.get<any[]>('https://localhost:7085/magnilearn/dashboard/teacher/get-most-learned-words');
    }
    
    getBestRankedExercises() {
        return this.http.get<any[]>('https://localhost:7085/magnilearn/dashboard/teacher/get-best-ranked-exercises');
    }
    
    getUsersGrades() {
        return this.http.get<any[]>('https://localhost:7085/magnilearn/dashboard/teacher/get-users-grades');
    }
}