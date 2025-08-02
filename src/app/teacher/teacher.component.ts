import { Component} from '@angular/core';
import { CommonModule } from '@angular/common'; 
import { FormsModule } from '@angular/forms';
import { TeacherService } from '../services/teacher.service';
import { Teacher } from '../models/teacher.model';
import { FirstcapPipe} from '../firstcap.pipe'
// import { HttpClient,HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-teacher',
  imports: [CommonModule,FormsModule,FirstcapPipe],
  templateUrl: './teacher.component.html',
  styleUrl: './teacher.component.scss'
})
export class TeacherComponent 
{
  comptitle = "Teachers Data"
teachers:Teacher[]= [];
id:number=0;
name: string='';
age:number=0;
subject:string='';
image:string='';
constructor(private teacherService: TeacherService)
{
 this.teacherService.getTeachers().subscribe((teachers)=>{
  this.teachers = teachers;
  } )
}
addTeacher():void
{
  if (this.name)
  {
    this.id=(this.teachers.length + 1);
    this.image= `https://randomuser.me/api/portraits/women/${this.id}.jpg`;
  var newTeacher: Teacher = { 
    id:this.id,
    name: this.name ,
    subject: this.subject,
    age: this.age,
    image: this.image,
  }
 this.teacherService.addTeacher(newTeacher);
  }
}


}