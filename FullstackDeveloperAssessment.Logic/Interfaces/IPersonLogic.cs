using FullstackDeveloperAssessment.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Logic.Interfaces
{
	public interface IPersonLogic
	{
		Person GetById(int Id);

		IEnumerable<Person> SelectLastRecords();

		IEnumerable<Person> SelectAllPerson();

		IEnumerable<Person> SearchPersons(Func<Person, bool> criteria);

		Task<Person> SavePerson(Person person);
	}
}
