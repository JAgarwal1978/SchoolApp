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
      this.students = students;
    })
  }

  addStudent(): void {
    if (this.firstName) {
      this.studentID = (this.students.length + 1);
      this.image = `https://randomuser.me/api/portraits/women/${this.studentID}.jpg`;      
      var newStudent : Student={
      "studentID": 3,
  "firstName": "John",
  "lastName": "Doe",
  "dateOfBirth": new Date('2021-08-03T03:44:01.896Z'),
  "gender": "M",
  "email": "ssdfd@dsff.com",
  "phone": "12324",
  "address": "pune",
  "cityID": 2,
  "cityName": "Pune",
  "city": "Pune"
      }
      this.studentService.addStudent(newStudent).subscribe({
        next: () => { this.studentService.getStudents().subscribe((students) => {
      this.students = students;
    })},
        error: (err) => {}
        
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
