using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Entyties
{
	public class PersonType
	{
		public int Id { get; set; }		
		public string Description { get; set; }
		public IEnumerable<PersonPersonType> PersonPersonTypes { get; set; }
		


	}
}
