import { Routes } from '@angular/router';

import { AboutComponent } from './app/about/about.component';
import { PersonComponent } from './app/person/person.component';
import { PersonFormComponent } from './app/person-form/person-form.component';
import { LastRecordsComponent } from './app/last-records/last-records.component';

export const appRoutes: Routes = [
    { path: 'about', component: AboutComponent },
    { path: 'persons', component: PersonComponent },
    { path: 'lastRecords', component: LastRecordsComponent },
    { path: 'create', component: PersonFormComponent },
    { path: '', redirectTo: '/persons', pathMatch: 'full' },

];