using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Entyties
{
	public class PersonAddress
	{
		public int Id { get; set; }		
		public string Address { get; set; }
		public string City { get; set; }
		public string StateProvinceRegion { get; set; }
		public string PostalZipCode { get; set; }
		public string Country { get; set; }
		public int PersonVAT { get; set; }
		public virtual Person Person { get; set; }		
	}
}
