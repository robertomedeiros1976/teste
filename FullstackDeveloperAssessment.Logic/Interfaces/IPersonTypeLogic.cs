using FullstackDeveloperAssessment.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Logic.Interfaces
{
	public interface IPersonTypeLogic
	{
		IEnumerable<PersonType> SelectAllPersonTypes();
	}
}
