import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../models/employee';
import { EmployeeService } from '../service/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.scss']
})
export class AddEmployeeComponent implements OnInit {

  employees: Employee[];
  name: string = '';
  role: string = '';

  constructor(private employeeService: EmployeeService, private router: Router) { }

  ngOnInit(): void {
  }

  addNewEmployee() {
    this.employeeService.addEmployee(this.name, this.role).subscribe(() => this.router.navigateByUrl(''));
  }


}
