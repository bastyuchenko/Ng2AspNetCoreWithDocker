import { Component, OnInit } from '@angular/core';

import { IEmployee } from './../models/employee';
import { EmployeeService } from './employee.service';

@Component({
    selector: 'employee-list',
    templateUrl: 'employee-list.component.html',
    styleUrls: ["employee.css"]
})

export class EmployeeListComponent implements OnInit {
    errorMessage: string;

    employees: IEmployee[];

    constructor(private _employeeService: EmployeeService) { }

    ngOnInit(): void {
        this._employeeService.getEmployees()
            .subscribe(employees => {
                this.employees = employees
            },
            error => {
                this.errorMessage = <any>error
            });
    }
}