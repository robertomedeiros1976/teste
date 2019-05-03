import { Person } from './person';

export class Address {
    public Id: number;
    public Address: string;
    public City: string;
    public StateProvinceRegion: string;
    public PostalZipCode: string;
    public Country: string;  
    public PersonVAT: number;
    public Person: Person;    
}