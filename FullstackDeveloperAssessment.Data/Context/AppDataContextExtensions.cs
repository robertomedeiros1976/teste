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
						Id = 1,
						Description = "Farmer"						
					},
					new PersonType()
					{
						Id = 2,
						Description = "Veterinary"
					},
					new PersonType()
					{
						Id = 3,
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
						PersonAddress = new PersonAddress()
						{
							Address = "Adams Street, 2323",
							City = "Lisbon",
							Country = "Portugal",
							PostalZipCode = "02323123",
							StateProvinceRegion = "Lisbon/Lisbon"							
						},
						SecretCode = "23232323"						
					},

					new Person()
					{
						Name = "Mary Jane",
						DateOfBirth = new DateTime(1983, 10, 16),
						DateOfRecord = DateTime.Now,
						Gender = Domain.Enumerators.Gender.Female,
						PersonAddress = new PersonAddress()
						{
							Address = "Columbus Street, 1020",
							City = "New York",
							Country = "United States",
							PostalZipCode = "00489852",
							StateProvinceRegion = "NY/Manhatan"
						},
						SecretCode = "2323232"
					},

					new Person()
					{
						Name = "Roberto Medeiros",
						DateOfBirth = new DateTime(1976, 11, 1),
						DateOfRecord = DateTime.Now,
						Gender = Domain.Enumerators.Gender.Male,
						PersonAddress = new PersonAddress()
						{
							Address = "Rua Viamão 271",
							City = "São Leopoldo",
							Country = "Brasil",
							PostalZipCode = "93037220",
							StateProvinceRegion = "Rio Grande do Sul"
						},
						SecretCode = "2323232"
					},
				});

				context.SaveChanges();
			}
		}
	}
}
