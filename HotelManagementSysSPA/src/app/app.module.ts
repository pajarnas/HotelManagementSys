import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {DatePipe} from '@angular/common';

//form
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

//routing user-defined
import { AppRoutingModule } from './app.routing';


//app app-root
import { AppComponent } from './app.component';


// my components
import { ComponentsModule } from  './components/components.module'



import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';

import {AdminLayoutModule} from "./layouts/admin-layout/admin-layout.module";






@NgModule({
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ComponentsModule,
    RouterModule,
    AppRoutingModule,
    AdminLayoutModule,


  ],
  declarations: [
    AppComponent,
    AdminLayoutComponent,









  ],
  providers: [],
  exports: [


  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
