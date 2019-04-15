import { Component, OnInit } from '@angular/core';

import {Person} from '../../models/person';
import { Address } from '../../models/address';
import { PersonType } from '../../models/personType';

import { PersonService } from './person.service';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  private persons: Person[];

  constructor(private personService: PersonService) { }

  ngOnInit() {
    this.getPersons();
  }

  getPersons(): void {
    this.personService.listPersons().subscribe(data => this.persons = data);
  }

}
