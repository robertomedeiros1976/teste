using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Service.Services
{
	public class PersonService : IPersonService
	{
		private IPersonRepository _repository;

		public PersonService(IPersonRepository repository)
		{
			this._repository = repository;
		}

		public Person Get(int Id)
		{
			try
			{
				return _repository.Select(Id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public IEnumerable<Person> ListLastPersons()
		{
			try
			{
				return _repository.SelectAll().OrderByDescending(a => a.DateOfRecord).Take(5);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public IEnumerable<Person> ListPersons()
		{
			try
			{
				return this._repository.SelectAll();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<Person> Save(Person person)
		{
			try
			{
				if (person.VAT == 0)
				{
					return await this._repository.InsertAsync(person);
				}
				else
				{
					return await this._repository.UpdateAsync(person);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
		}

		public IEnumerable<Person> SearchPerson(Func<Person, bool> criteria)
		{
			try
			{
				return this._repository.Search(criteria);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
