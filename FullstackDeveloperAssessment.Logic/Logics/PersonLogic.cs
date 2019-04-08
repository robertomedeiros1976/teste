using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Logic.Logics
{
	public class PersonLogic 
	{
		private IPersonService _service;

		public PersonLogic(IPersonService service)
		{
			this._service = service;
		}

		public Person GetById(int Id)
		{
			try
			{
				return _service.Get(Id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public IEnumerable<Person> SelectLastRecords()
		{
			try
			{
				return _service.ListLastPersons();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public IEnumerable<Person> SelectAllPerson()
		{
			try
			{
				return _service.ListPersons();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public IEnumerable<Person> SearchPersons(Func<Person, bool> criteria)
		{
			try
			{
				return _service.SearchPerson(criteria);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public bool SavePerson(Person person)
		{
			try
			{
				return _service.Save(person);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


	}

}
