import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { StudentService } from '../services/student.service';
import { Student } from '../models/student.model';
import { FirstcapPipe } from '../firstcap.pipe'

@Component({
  selector: 'app-student',
  imports: [CommonModule, FormsModule, FirstcapPipe],
  templateUrl: './student.component.html',
  styleUrl: './student.component.scss'
})
export class StudentComponent {
  comptitle = "Students Data"
  students: Student[] = [];
  age: number = 0;
  subject: string = '';
  image: string = '';
  studentID: number = 0;
  firstName: string = '';
  lastName: string = '';
  dateOfBirth: Date = new Date();
  gender: string = '';
  email: string = '';
  phone: string = '';
  address: string = '';
  cityID: number = 0;
  constructor(private studentService: StudentService) {
    this.studentService.getStudents().subscribe((students) => {
      this.students = students;
    })
  }

  addStudent(): void {
    if (this.firstName) {
      this.studentID = (this.students.length + 1);
      this.image = `https://randomuser.me/api/portraits/women/${this.studentID}.jpg`;

      // var newStudent: Student = {
      //   studentID: this.studentID,
      //   firstName: this.firstName,
      //   lastName: this.lastName,
      //   dateOfBirth: this.dateOfBirth,
      //   gender: this.gender,
      //   email: this.email,
      //   phone: this.phone,
      //   address: this.address,
      //   cityID: this.cityID
      // }
      var newStudent : Student={
      "studentID": 0,
  "firstName": "string",
  "lastName": "string",
  "dateOfBirth": new Date('2025-08-03T03:44:01.896Z'),
  "gender": "string",
  "email": "string",
  "phone": "string",
  "address": "string",
  "cityID": 0,
  "cityName": "string",
  "city": "string"
      }
      this.studentService.addStudent(newStudent);
    }

  }
}
