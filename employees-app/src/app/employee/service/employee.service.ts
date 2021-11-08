import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../models/employee';

@Injectable(
)
export class EmployeeService {

  readonly baseUrl = "https://localhost:44302";

  readonly httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  };

  constructor(private httpClient: HttpClient) { }

  getEmployees(): Observable<Employee[]> {
    return this.httpClient.get<Employee[]>(this.baseUrl + '/employees', this.httpOptions);
  }

  addEmployee(newName: string, newRole: string): Observable<Employee[]> {
    let employee = {
      name: newName,
      role: newRole,
    }
    return this.httpClient.post<Employee[]>(this.baseUrl + "/employees", employee);
  }

  deleteEmployee(id: string) {
    return this.httpClient.delete(this.baseUrl + '/employees/' + id);
  }

}
