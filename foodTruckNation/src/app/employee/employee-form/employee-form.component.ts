import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-employee-form',
  templateUrl: './employee-form.component.html',
  styleUrls: ['./employee-form.component.css']
})
export class EmployeeFormComponent implements OnInit {
  formGroup: FormGroup;
  constructor(
    // private fb: FormBuilder
  ) { }

  ngOnInit() {
    // this.formGroup = this.fb.group({
    //   id: [''],
    //   firstName: ['', Validators.required],
    //   lastName: ['', Validators.required],
    //   age: ['', Validators.required],
    //   salary: ['', Validators.required]
    // });
  }

}
