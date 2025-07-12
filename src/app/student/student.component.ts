import { Component } from '@angular/core';
import { CommonModule } from '@angular/common'; 

@Component({
  selector: 'app-student',
  imports: [CommonModule],
  templateUrl: './student.component.html',
  styleUrl: './student.component.scss'
})
export class StudentComponent 
{
  comptitle = "Students Data"

students = [{
    name: 'Jaswant',
    age: 20,
    course: 'Computer Science',
    image:'https://randomuser.me/api/portraits/men/3.jpg',
  },
{
    name: 'Shraddha',
    age: 25,
    course: 'English',
    image:'https://randomuser.me/api/portraits/women/1.jpg',
  },
{
    name: 'Somi',
    age: 20,
    course: 'Science',
    image:'https://randomuser.me/api/portraits/men/4.jpg',
  },
{
    name: 'Sumita',
    age: 26,
    course: 'Computer',
    image:'https://randomuser.me/api/portraits/women/3.jpg',
  },
{
    name: 'Sumita',
    age: 26,
    course: 'Computer',
    image:'https://randomuser.me/api/portraits/women/7.jpg',
  },
{
    name: 'Sumita',
    age: 26,
    course: 'Computer',
    image:'https://randomuser.me/api/portraits/women/6.jpg',
  },
{
    name: 'Sumita',
    age: 26,
    course: 'Computer',
    image:'https://randomuser.me/api/portraits/women/5.jpg',
  }];

}
