import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { appRoutes } from '../routes';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { PersonComponent } from './person/person.component';
import { AboutComponent } from './about/about.component';
import { PersonFormComponent } from './person-form/person-form.component';
import { LastRecordsComponent } from './last-records/last-records.component';
import { RouterModule } from '@angular/router';

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
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
