import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Person } from '../../models/person';
import { Address } from '../../models/address';
import { PersonType } from '../../models/personType';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class PersonService {

  private readonly API = `${environment.API}`;

  constructor(private http: HttpClient) { }

  listPersons(){
    return this.http.get<Person[]>(`${this.API}/person`);
  }
}
