import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserModule } from './components/user/user.module';
import { HomeComponent } from './views/home/home.component';
import { TemplateModule } from './templates/template.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatCardModule } from  '@angular/material/card';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatNativeDateModule} from '@angular/material/core';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    UserModule,
    TemplateModule,
    BrowserAnimationsModule,
    MatCardModule,
    ReactiveFormsModule,
    MatNativeDateModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
