import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { FormControl,FormGroup } from '@angular/forms'; 
import { Course } from '../../classes/Course';
import { CourseService } from '../../services/course.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-add',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule, CommonModule],
  templateUrl: './course-add.component.html',
  styleUrl: './course-add.component.css'
})
export class CourseAddComponent {

  //The form setup
addForm:FormGroup = new FormGroup({
  courseName:new FormControl(" "),
  courseDuration:new FormControl(" "),
  courseDescription:new FormControl(" "),


})

  constructor(private courseService: CourseService , private route:Router){

  }

  ngOnInit()
  {
this.FormRest();
  }

  FormRest()
  {
    this.addForm.reset();
  }

  onAdd(){
    let courseSchool = new Course();
    courseSchool.courseName = this.addForm.controls["courseName"].value;
     courseSchool.courseDuration = this.addForm.controls["courseDuration"].value;
     courseSchool.courseDescription = this.addForm.controls["courseDescription"].value;

     this.courseService.AddCourse(courseSchool).subscribe({
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
