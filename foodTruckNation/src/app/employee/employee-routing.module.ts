import { Routes, RouterModule } from '@angular/router';
import { EmployeeComponent } from './employee.component';
import { NgModule } from '@angular/core';

const routes: Routes = [
    { path: '', redirectTo: '/employee', pathMatch: 'full' },
    { path: 'employee', component: EmployeeComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)]
})
export class EmployeeRoutingModule { }
