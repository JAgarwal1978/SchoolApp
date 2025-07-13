import { Component} from '@angular/core';
import { CommonModule } from '@angular/common'; 
import { FormsModule } from '@angular/forms';
import { TeacherService } from '../services/teacher.service';
import { Teacher } from '../models/teacher.model';
// import { HttpClient,HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-teacher',
  imports: [CommonModule,FormsModule],
  templateUrl: './teacher.component.html',
  styleUrl: './teacher.component.scss'
})
export class TeacherComponent 
{
  comptitle = "Teachers Data"
teachers:Teacher[]= [];
constructor(private teacherService: TeacherService)
{
 this.teacherService.getTeachers().subscribe((teachers)=>{
  this.teachers = teachers;
  } )
}
addTeacher():void
{
  var newTeacher: Teacher = { 
    id:0,
    name: '' ,
    subject: '',
    age: 0,
    image: '',
  }
 this.teacherService.addTeacher(newTeacher);
}


}