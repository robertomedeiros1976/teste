using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Service.Services
{
	public class PersonTypeService : IPersonTypeService
	{
		private IRepositoryBase<PersonType> _repository;

		public PersonTypeService(IRepositoryBase<PersonType> repository)
		{
			this._repository = repository;
		}


		public IEnumerable<PersonType> SelectAllPersonTypes()
		{
			try
			{
				return _repository.SelectAll();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
