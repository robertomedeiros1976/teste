using FullstackDeveloperAssessment.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FullstackDeveloperAssessment.Data.Context
{
	public static class AppDataContextExtensions
	{
		public static void EnsureDatabaseSeeded(this AppDataContext context)
		{
			if (!context.PersonTypes.Any())
			{
				context.AddRange(new PersonType[]
				{
					new PersonType()
					{						
						Description = "Farmer"						
					},
					new PersonType()
					{
						Description = "Veterinary"
					},
					new PersonType()
					{
						Description = "Owner"
					},
				});

				context.SaveChanges();
			}

			if (!context.Persons.Any())
			{
				context.AddRange(new Person[]
				{
					new Person()
					{						
						Name = "John Jones",
						DateOfBirth = new DateTime(1977, 2, 6),
						DateOfRecord = DateTime.Now,
						Gender = Domain.Enumerators.Gender.Male,
						SecretCode = "23232323"						
					},

					new Person()
					{
						
						Name = "Mary Jane",
						DateOfBirth = new DateTime(1983, 10, 16),
						DateOfRecord = DateTime.Now,
						Gender = Domain.Enumerators.Gender.Female,						
						SecretCode = "2323232"						
					},

					new Person()
					{
						
						Name = "Roberto Medeiros",
						DateOfBirth = new DateTime(1976, 11, 1),
						DateOfRecord = DateTime.Now,
						Gender = Domain.Enumerators.Gender.Male,						
						SecretCode = "2323232"
					},
				});

				context.SaveChanges();
			}

			var person1 = context.Persons.FirstOrDefault(x => x.Name.Equals("John Jones"));
			var person2 = context.Persons.FirstOrDefault(x => x.Name.Equals("Mary Jane"));
			var person3 = context.Persons.FirstOrDefault(x => x.Name.Equals("Roberto Medeiros"));
			var personType1 = context.PersonTypes.FirstOrDefault(x => x.Description.Equals("Farmer"));
			var personType2 = context.PersonTypes.FirstOrDefault(x => x.Description.Equals("Vaterinary"));
			var personType3 = context.PersonTypes.FirstOrDefault(x => x.Description.Equals("Owner"));

			if (!context.PersonsPersonTypes.Any())
			{
				context.AddRange(new PersonPersonType[] 
				{
					new PersonPersonType()
					{
						Person = person1,
						PersonType = personType1,
					},

					new PersonPersonType()
					{
						Person = person1,
						PersonType = personType2,
					},

					new PersonPersonType()
					{
						Person = person2,
						PersonType = personType2,
					},

					new PersonPersonType()
					{
						Person = person3,
						PersonType = personType3,
					},

					new PersonPersonType()
					{
						Person = person3,
						PersonType = personType1,
					},
				});

				context.SaveChanges();
			}

			if (!context.PersonAddresses.Any())
			{		

				context.AddRange(new PersonAddress[] 
				{
					new PersonAddress()
					{
						Person = person1,
						Address = "Adams Street, 2323",
						City = "Lisbon",
						Country = "Portugal",
						PostalZipCode = "02323123",
						StateProvinceRegion = "Lisbon/Lisbon"
					},

					new PersonAddress()
					{
						Person = person2,
						Address = "Columbus Street, 1020",
						City = "New York",
						Country = "United States",
						PostalZipCode = "00489852",
						StateProvinceRegion = "NY/Manhatan"
					},

					new PersonAddress()
					{
						Person = person3,
						Address = "Rua Viamão 271",
						City = "São Leopoldo",
						Country = "Brasil",
						PostalZipCode = "93037220",
						StateProvinceRegion = "Rio Grande do Sul"
					}
				});

				context.SaveChanges();

				
			}
		}
	}
}
