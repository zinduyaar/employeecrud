import { NgModule } from '@angular/core';
import { EmployeeComponent } from './employee.component';
import { EmployeeRoutingModule } from './employee-routing.module';
import { EmployeeFormComponent } from './employee-form/employee-form.component';
import { EmployeeGridComponent } from './employee-grid/employee-grid.component';
import { CommonModule } from '@angular/common';

@NgModule({
    declarations: [
        EmployeeComponent,
        EmployeeFormComponent,
        EmployeeGridComponent
    ],
    imports: [
        EmployeeRoutingModule,
        CommonModule
    ]
})
export class EmployeeModule { }
