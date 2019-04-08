using FullstackDeveloperAssessment.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Interfaces
{
	public interface IPersonService
	{
		bool Save(Person person);
		IEnumerable<Person> ListPersons();
		IEnumerable<Person> ListLastPersons();
		IEnumerable<Person> SearchPerson(Func<Person, bool> criteria);


	}
}
