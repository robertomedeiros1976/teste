import { Address } from './address';
import { PersonType } from './personType';


export class Person {
    public VAT: number;
    public Name: string;
    public Address: Address;
    public DateOfBirth: Date;
    public personTypes: PersonType[];
    public Gender: Gender;
    public SecretCode: string;
    public DateOfRecord: Date;
}

enum Gender {
    Male = 1,
    Female = 2
}