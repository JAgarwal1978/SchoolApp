import { ChangeDetectorRef, Component } from '@angular/core';
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
  constructor(private studentService: StudentService, private cdr: ChangeDetectorRef) {
    this.studentService.getStudents().subscribe((students) => {
      for (let student of students) {

        student.image = `https://randomuser.me/api/portraits/women/${student.studentID}.jpg`;
      }
      this.students = students;
    })
  }

  addStudent(): void {
    if (this.firstName) {
      this.studentID = (this.students.length + 1);
      this.image = `https://randomuser.me/api/portraits/women/${this.studentID}.jpg`;
      var newStudent: Student = {
        "studentID": this.studentID,
        "firstName": this.firstName,
        "lastName": this.lastName,
        "dateOfBirth": new Date(this.dateOfBirth),
        "gender": this.gender,
        "email": this.email,
        "phone": this.phone,
        "address": this.address,
        "cityID": this.cityID,
        "cityName": "Pune",
        "city": "Pune",
        "image": "",
      }
      this.studentService.addStudent(newStudent).subscribe({
        next: () => {
          this.studentService.getStudents().subscribe((students) => {
            for (let student of students) {

              student.image = `https://randomuser.me/api/portraits/women/${student.studentID}.jpg`;
            }
            this.students = students;
          })
        },
        error: (err) => { }

      });


      this.cdr.detectChanges();
    }

  }

  getStudents(): void {
    this.studentService.getStudents().subscribe((students) => {
      this.students = students;
    }, error => {
      console.error('Error fetching students:', error);
    });

  }
}
