import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})

export class DataService {
    baseURL: string;

    constructor(private http: HttpClient) {
        this.baseURL = "https://localhost:7085/magnilearn/dashboard/";
    }

    //User services
    getUserEffort(userId: number) {
        return this.http.get<any>(this.baseURL + '/student/' + userId + '/effort');
    }

    getUserPerformance(userId: number) {
        return this.http.get<any[]>(this.baseURL + '/student/' + userId + '/performance');
    }

    getUserLearnedVocabulary(userId: number) {
        return this.http.get<any[]>(this.baseURL + '/student/' + userId + '/learnedVocabulary');
    }

    getUserProgress(userId: number) {
        return this.http.get<any>(this.baseURL + '/student/' + userId + '/progress');
    }

    getUserGrade(userId: number) {
        return this.http.get<any[]>(this.baseURL + '/student/' + userId + '/grade');
    }

    //Teacher services
    getStudentsOverallPerformance() {
        return this.http.get<any[]>(this.baseURL + '/teacher/students-overall-performance');
    }
    
    getMostLearnedWords() {
        return this.http.get<any[]>(this.baseURL + '/teacher/get-most-learned-words');
    }
    
    getBestRankedExercises() {
        return this.http.get<any[]>(this.baseURL + '/teacher/get-best-ranked-exercises');
    }
    
    getUsersGrades() {
        return this.http.get<any[]>(this.baseURL + '/teacher/get-users-grades');
    }
}