using FullstackDeveloperAssessment.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Domain.Interfaces
{
	public interface IPersonService
	{
		Task<Person> Save(Person person);
		IEnumerable<Person> ListPersons();
		IEnumerable<Person> ListLastPersons();
		IEnumerable<Person> SearchPerson(Func<Person, bool> criteria);
		Person Get(int Id);


	}
}
