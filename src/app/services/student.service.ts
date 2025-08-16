import { Injectable } from '@angular/core';
import { Student } from '../models/student.model';
import { BehaviorSubject, Observable,throwError } from 'rxjs';
import { HttpClient,HttpErrorResponse } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class StudentService
{
private students:Student[] = [];
private studentSubject = new BehaviorSubject<Student[]>(this.students);  
private apiUrlGetStudents = 'http://localhost:18292/GetStudents';
private apiUrladdStudents ="http://localhost:18292/AddStudent";
constructor(private http: HttpClient) 
{ }

 addStudent(student:Student): Observable<Student>
  {
    //this.students.push(student);
  //   this.http.post(this.apiUrladdStudents,student).subscribe({
  // next: res => console.log('Success', res),
  // error: err => console.error('Error', err)
//});
    return this.http.post<Student>(this.apiUrladdStudents, student).pipe(
      catchError(this.handleError)
    );
    this.studentSubject.next(this.students);
  }
 handleError(error: HttpErrorResponse):Observable<any> {
  let errorMessage = 'Unknown error occurred';

    if (error.error instanceof ErrorEvent) {
      // Client-side or network error
      errorMessage = `Client error: ${error.error.message}`;
    } else {
      // Server-side error
      errorMessage = `Server error (${error.status}): ${error.message}`;
    }

    return throwError(() => new Error(errorMessage));
 }

  getStudents():Observable<Student[]>
  {
    // return this.studentSubject.asObservable();
    return this.http.get<Student[]>(this.apiUrlGetStudents);
  }
}
