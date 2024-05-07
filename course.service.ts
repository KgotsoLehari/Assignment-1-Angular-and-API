import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Course } from '../classes/Course';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor(private http:HttpClient) { }
  endpoint:string = "https://localhost:44333/api/Course/"


  GetAllCourses()
  {
    return this.http.get<Course[]>(this.endpoint + "getAllCourses" );
  }

  GetCourses(courseId:number)
  {
    return this.http.get<Course>(this.endpoint + `getAllCourses/${courseId}`);
  }


  AddCourse(course: Course)
  {
    return this.http.post<string>(this.endpoint + "addCourse", course );
  }

  UpdateCourse(course: Course)
  {
    return this.http.post<string>(this.endpoint + "updateCourse", course ,{
      headers: {
        'Content-Type': 'application/json'
      }
    });
  }

  DeleteCourse(courseId: number)
  {
    return this.http.delete<Course>(this.endpoint + `deleteCourse/${courseId}` );
  }
}
