using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FullstackDeveloperAssessment.Service.Services
{
	public class PersonService : IPersonService
	{
		private IRepositoryBase<Person> _repository;

		public PersonService(IRepositoryBase<Person> repository)
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

		IEnumerable<Person> IPersonService.ListLastPersons()
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

		IEnumerable<Person> IPersonService.ListPersons()
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

		bool IPersonService.Save(Person person)
		{
			try
			{
				if (person.VAT == 0)
				{
					return this._repository.Insert(person);
				}
				else
				{
					return this._repository.Update(person);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
		}

		IEnumerable<Person> IPersonService.SearchPerson(Func<Person, bool> criteria)
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
