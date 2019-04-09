using FullstackDeveloperAssessment.Data.Context;
using FullstackDeveloperAssessment.Domain.Entyties;
using FullstackDeveloperAssessment.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Data.Repository
{
	public class PersonRepository : IPersonRepository, IDisposable
	{
		protected readonly AppDataContext _context;

		public PersonRepository(AppDataContext context)
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

		public async Task<Person> InsertAsync(Person entity)
		{
			_context.Persons.Add(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public bool Remove(int Id)
		{
			_context.Persons.Remove(Select(Id));
			int result = _context.SaveChanges();

			return result > 0;
		}

		public IList<Person> Search(Func<Person, bool> criteria)
		{
			return _context.Persons.Include(a => a.PersonAddress).Include(a => a.PersonTypes).Where(criteria).ToList();
		}

		public Person Select(int Id)
		{
			return _context.Persons.Include(a => a.PersonAddress).Include(a => a.PersonTypes).FirstOrDefault(a => a.VAT == Id);
		}

		public IList<Person> SelectAll()
		{
			return _context.Persons.Include(a => a.PersonAddress).Include(a => a.PersonTypes).ToList();
		}

		public IList<Person> SelectLastPersons()
		{
			return _context.Persons.Include(a => a.PersonAddress).Include(a => a.PersonTypes).Take(0).Skip(5).ToList();
		}

		public async Task<Person> UpdateAsync(Person entity)
		{
			_context.Entry(entity).State = EntityState.Modified;
			await _context.SaveChangesAsync();

			return entity;
		}
	}
}
