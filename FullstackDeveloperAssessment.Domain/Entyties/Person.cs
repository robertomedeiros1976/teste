using System;
using System.Collections.Generic;
using System.Text;
using FullstackDeveloperAssessment.Domain.Enumerators;

namespace FullstackDeveloperAssessment.Domain.Entyties
{
	public class Person
	{
		public int VAT { get; set; }
		public string Name { get; set; }
		public PersonAddress PersonAddress { get; set; }
		public DateTime DateOfBirth { get; set; }
		public virtual IEnumerable<PersonPersonType> PersonPersonTypes { get; set; }
		public Gender Gender { get; set; }
		public string SecretCode { get; set; }		

	}



}
