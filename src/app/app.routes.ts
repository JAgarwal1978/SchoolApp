import { Routes } from '@angular/router';
import { StudentComponent } from './student/student.component';
import { TeacherComponent } from './teacher/teacher.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    
    {path:'student',component:StudentComponent},
    {path:'teacher',component:TeacherComponent},
 {path:'',component:HomeComponent}
];
