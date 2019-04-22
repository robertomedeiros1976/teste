using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Domain.Interfaces;
using FullstackDeveloperAssessment.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Logic.Logics
{
	public class PersonTypeLogic : IPersonTypeLogic
	{
		private IPersonTypeService _service;

		public PersonTypeLogic(IPersonTypeService service)
		{
			this._service = service;
		}

		public IEnumerable<PersonType> SelectAllPersonTypes()
		{
			try
			{
				return _service.SelectAllPersonTypes();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
