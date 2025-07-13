import { Injectable } from '@angular/core';
import { Teacher } from '../models/teacher.model';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TeacherService {
private teachers:Teacher[] = [];

private teacherSubject = new BehaviorSubject<Teacher[]>(this.teachers);

  constructor() { }

  addTeacher(teacher:Teacher): void
  {
    this.teachers.push(teacher);
    this.teacherSubject.next(this.teachers);
  }

  getTeachers():Observable<Teacher[]>
  {
    return this.teacherSubject.asObservable();
  }
}
