import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Employee } from '../employee.model';

@Component({
  selector: 'app-employee-grid',
  templateUrl: './employee-grid.component.html',
  styleUrls: ['./employee-grid.component.css']
})
export class EmployeeGridComponent implements OnInit {
  employeeList: Employee[];
  constructor(
    private employeeService: EmployeeService
  ) { }

  ngOnInit() {
    this.employeeService.getAllEmployees()
      .pipe()
      .subscribe((employees: any) => {
        this.employeeList = employees;
      });
  }
  onEditEmployee(emp: any) {
    console.log(emp);
  }
  onDeleteEmployee(emp: any) {
    console.log(emp);
  }

}
