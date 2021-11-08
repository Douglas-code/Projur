import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserCreateComponent } from './user-create/user-create.component';
import { UserReadComponent } from './user-read/user-read.component';
import { UserUpdateComponent } from './user-update/user-update.component';
import { UserCrudComponent } from 'src/app/views/user-crud/user-crud.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from  '@angular/material/button';
import { AppRoutingModule } from 'src/app/app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCardModule } from  '@angular/material/card';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatNativeDateModule} from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { HttpClientModule } from '@angular/common/http';
import { MatTableModule } from '@angular/material/table';

@NgModule({
  declarations: [
    UserCrudComponent,
    UserCreateComponent,
    UserReadComponent,
    UserUpdateComponent
  ],
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    BrowserModule,
    MatButtonModule,
    AppRoutingModule,
    MatFormFieldModule,
    MatCardModule,
    MatDatepickerModule,
    ReactiveFormsModule,
    MatNativeDateModule,
    MatInputModule,
    MatSelectModule,
    FormsModule,
    MatSnackBarModule,
    HttpClientModule,
    MatTableModule
  ],
  exports:[
    UserCrudComponent,
    UserCreateComponent,
    UserReadComponent,
    UserUpdateComponent
  ]
})
export class UserModule { }
