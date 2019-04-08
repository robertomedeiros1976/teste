using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Domain.Interfaces
{
	public interface IRepositoryBase<T> where T : class
	{
		bool Insert(T entity);
		bool Update(T entity);
		bool Remove(int Id);
		T Select(int Id);
		IList<T> SelectAll();
		IList<T> Search(Func<T, bool> criteria);
		IList<T> SelectLastPersons();
	}
}
