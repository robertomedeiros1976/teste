import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { appRoutes } from '../routes';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { PersonComponent } from './person/person.component';
import { AboutComponent } from './about/about.component';
import { PersonFormComponent } from './person-form/person-form.component';
import { LastRecordsComponent } from './last-records/last-records.component';

import { PersonService } from './person/person.service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    PersonComponent,
    AboutComponent,
    PersonFormComponent,
    LastRecordsComponent    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [PersonService],
  bootstrap: [AppComponent]
})
export class AppModule { }
