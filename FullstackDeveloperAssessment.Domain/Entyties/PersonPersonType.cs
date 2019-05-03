using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Entyties
{
	public class PersonPersonType
	{
		public int Id { get; set; }
		public int PersonVAT { get; set; }
		public Person Person { get; set; }
		public int PersonTypeId { get; set; }
		public PersonType PersonType { get; set; }
	}
}
