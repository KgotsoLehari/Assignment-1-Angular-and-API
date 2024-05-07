import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule} from '@angular/forms';
import { CourseService } from '../../services/course.service';
import { Router } from '@angular/router';
import { Course } from '../../classes/Course';
import { Subscription } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-update',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule , CommonModule],
  templateUrl: './course-update.component.html',
  styleUrl: './course-update.component.css'
})
export class CourseUpdateComponent {

  
  //The form setup
updateForm:FormGroup = new FormGroup({
  courseName:new FormControl(" "),
  courseDuration:new FormControl(" "),
  courseDescription:new FormControl(" "),


})

  receiveData!: Subscription;
  courseId!:number
  courseEdu!:Course;

  constructor(private courseService: CourseService , private route:Router , private activatedRoute:ActivatedRoute){

  }

  ngOnInit()
  {
    this.receiveData = this.activatedRoute.params.subscribe(parms =>{
      this.courseId = parms["courseId"];
      this.FetchCourse();
    })
  }

  FetchCourse()
  {
    this.courseService.GetCourses(this.courseId).subscribe({
      next: res=> {
        console.log(res);
        this.FormRest();
        this.courseEdu = res;
        this.assignValues();
        
      },

     error:err =>{
      console.log(err);
     }
    });
  }

  

  assignValues()
  {
    this.updateForm.controls["courseName"].setValue(this.courseEdu.courseName);
    this.updateForm.controls["courseDuration"].setValue(this.courseEdu.courseDuration);
    this.updateForm.controls["courseDescription"].setValue(this.courseEdu.courseDescription);
  }

  FormRest()
  {
    this.updateForm.reset();
  }

  onUpdate(){

    let courseSchool = new Course();
      courseSchool.courseId = this.courseEdu.courseId;
      courseSchool.courseName = this.updateForm.controls["courseName"].value;
      courseSchool.courseDuration = this.updateForm.controls["courseDuration"].value;
      courseSchool.courseDescription = this.updateForm.controls["courseDescription"].value;

      this.courseService.UpdateCourse(courseSchool).subscribe({
        next: res=> {
          console.log(res);
          this.FormRest();
          this.route.navigateByUrl("/home")
          
        },

       error:err =>{
        console.log(err);
       }
      });
      this.route.navigateByUrl("/home")

    


  }

  onCancel()
  {
    this.route.navigateByUrl("/home")

  }

  ReloadPage():void
  {
    this.route.navigateByUrl("/home")
    window.location.reload();
  }

}
