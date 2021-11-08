import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../models/employee';
import { EmployeeService } from '../service/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.scss']
})
export class EmployeeComponent implements OnInit {

  employees: Employee[];
  name: string = '';
  role: string = '';

  constructor(private employeeService: EmployeeService, private router: Router) { }

  ngOnInit(): void {

    this.getEmployees();
  }

  getEmployees(){
    this.employeeService.getEmployees().subscribe((result) => {
      this.employees = result;
    })
  }

  deleteEmployee(id: string) {
    this.employeeService.deleteEmployee(id).subscribe(() => this.getEmployees());
  }
}
