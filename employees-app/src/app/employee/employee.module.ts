import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card';
import { MatSelectModule } from '@angular/material/select';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeService } from './service/employee.service';
import {MatToolbarModule} from '@angular/material/toolbar';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from '../app-routing.module';
import { ToolsComponent } from './tools/tools.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';



@NgModule({
  declarations: [
    HomeComponent,
    EmployeeComponent,
    ToolsComponent,
    AddEmployeeComponent
  ],
  imports: [
  BrowserModule,
  AppRoutingModule,
  BrowserAnimationsModule,
  CommonModule,
  MatButtonModule,
  MatIconModule,
  MatInputModule,
  MatFormFieldModule,
  FormsModule,
  CommonModule,
  MatCardModule,
  MatSelectModule,
  MatToolbarModule,
  HttpClientModule

  ],
  providers:[EmployeeService],
  exports:[HomeComponent, EmployeeComponent],
})
export class EmployeeModule { }
