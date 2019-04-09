using FullstackDeveloperAssessment.Data.Context;
using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Data.Repository
{
	public class PersonTypeRepository : IPersonTypeRepository, IDisposable
	{
		protected readonly AppDataContext _context;

		public PersonTypeRepository(AppDataContext context)
		{
			this._context = context;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{

			}
		}

		public Task<PersonType> InsertAsync(PersonType entity)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int Id)
		{
			throw new NotImplementedException();
		}

		public IList<PersonType> Search(Func<PersonType, bool> criteria)
		{
			throw new NotImplementedException();
		}

		public PersonType Select(int Id)
		{
			throw new NotImplementedException();
		}

		public IList<PersonType> SelectAll()
		{
			return _context.PersonTypes.ToList();
		}

		public IList<PersonType> SelectLastPersons()
		{
			throw new NotImplementedException();
		}

		public Task<PersonType> UpdateAsync(PersonType entity)
		{
			throw new NotImplementedException();
		}
	}
}
