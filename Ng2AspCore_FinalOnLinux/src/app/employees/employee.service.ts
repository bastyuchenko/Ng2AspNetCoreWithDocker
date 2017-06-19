import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/throw';

import { IEmployee } from './../models/employee';

@Injectable()
export class EmployeeService {
    constructor(private _http: Http) { }

    getEmployees(): Observable<IEmployee[]> {
        return this._http.get('/api/EmployeeMongodb/GetAll')
            .map((response: Response) => <IEmployee[]> response.json())
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}