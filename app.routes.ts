import { Routes } from '@angular/router';
import { CourseListComponent } from './courses/course-list/course-list.component';
import { CourseUpdateComponent } from './courses/course-update/course-update.component';
import { CourseAddComponent } from './courses/course-add/course-add.component';

 export const routes: Routes = [
    {path:'' , pathMatch:'full' , redirectTo: 'home'},
    {path:'home' , component:CourseListComponent},
    {path:'update/:courseId' , component:CourseUpdateComponent},
    {path:'add' , component:CourseAddComponent},


 ];
