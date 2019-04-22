import { Address } from './address';
import { PersonPersonType } from './personPersonType';


export class Person {
    public Vat: number;
    public Name: string;
    public PersonAddress: Address;
    public DateOfBirth: Date;
    public PersonPersonTypes: PersonPersonType[];
    public Gender: Gender;
    public SecretCode: string;
    public DateOfRecord: Date;
}

enum Gender {
    Male = 1,
    Female = 2
}