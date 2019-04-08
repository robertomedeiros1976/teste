using FullstackDeveloperAssessment.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Interfaces
{
	public interface IPersonTypeService
	{
		IEnumerable<PersonType> SelectAllPersonTypes();
	}
}
