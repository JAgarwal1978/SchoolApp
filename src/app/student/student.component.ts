import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common'; 

@Component({
  selector: 'app-student',
  imports: [CommonModule,HttpClientModule],
  templateUrl: './student.component.html',
  styleUrl: './student.component.scss'
})
export class StudentComponent implements OnInit
{
  comptitle = "Students Data"
students:any;
constructor(private httpclient:HttpClient)
{

}
ngOnInit(): void {
  this.httpclient.get<any>('/assets/student.json').subscribe((response) =>{
    this.students = response;
    // delete this.students[0]
    console.log(response);
  }
  )
}

}
