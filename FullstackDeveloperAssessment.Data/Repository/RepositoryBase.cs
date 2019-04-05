using FullstackDeveloperAssessment.Data.Context;
using FullstackDeveloperAssessment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FullstackDeveloperAssessment.Data.Repository
{
	public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
	{
		protected readonly AppDataContext _context;

		public RepositoryBase(AppDataContext context)
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

		public bool Insert(T entity)
		{
			_context.Set<T>().Add(entity);
			int result = _context.SaveChanges();

			return result > 0;
		}

		public bool Remove(long Id)
		{
			_context.Set<T>().Remove(Select(Id));
			int result = _context.SaveChanges();

			return result > 0;
		}

		public T Select(long Id)
		{
			return _context.Set<T>().Find(Id);
		}

		public IList<T> SelectAll()
		{
			return _context.Set<T>().ToList();
		}

		public bool Update(T entity)
		{
			_context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			int result = _context.SaveChanges();

			return result > 0;
		}

		public IList<T> Search(Func<T, bool> criteria)
		{
			return _context.Set<T>().Where(criteria).ToList();
		}
	}
}
