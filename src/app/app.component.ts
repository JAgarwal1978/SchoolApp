import { Component } from '@angular/core';
import { RouterOutlet,RouterModule } from '@angular/router';
// import {StudentComponent} from './student/student.component'
// import { TeacherComponent } from './teacher/teacher.component'; 
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,RouterModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'my-angular-app';
}
