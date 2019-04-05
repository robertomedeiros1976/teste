using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Entyties
{
	public class PersonType
	{
		public int Id { get; set; }
		//public int PersonVAT { get; set; }
		public string Description { get; set; }

		public virtual IEnumerable<PersonPersonType> PersonPersonTypes { get; set; }

		
	}
}
