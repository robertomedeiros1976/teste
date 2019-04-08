using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Interfaces
{
	public interface IRepositoryBase<T> where T : class
	{
		bool Insert(T entity);
		bool Update(T entity);
		bool Remove(long Id);
		T Select(long Id);
		IList<T> SelectAll();
		IList<T> Search(Func<T, bool> criteria);
		IList<T> SelectLastPersons();
	}
}
