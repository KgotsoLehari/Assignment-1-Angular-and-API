import { Component } from '@angular/core';
import { CourseService } from '../../services/course.service';
import { Course } from '../../classes/Course';
import { CommonModule } from '@angular/common';
import {  RouterLink } from '@angular/router';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule ,RouterLink],
  templateUrl: './course-list.component.html',
  styleUrl: './course-list.component.css'
})
export class CourseListComponent {

  constructor (private courseService:CourseService ){}
  courses: Course[] = [];

  ngOnInit()
  {
    this.getAllCourses();
    
  }

  getAllCourses()
  {
    this.courseService.GetAllCourses().subscribe(res =>{
      this.courses= res;
      console.log(res);

    });
  }

  Delete(courseId: number)
  {
    this.courseService.DeleteCourse(courseId).subscribe(res =>{
      this.getAllCourses();
    });
  }

  ReloadPage()
  {
    window.location.reload();
  }

}
