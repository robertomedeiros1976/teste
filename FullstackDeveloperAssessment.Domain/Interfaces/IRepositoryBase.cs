using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FullstackDeveloperAssessment.Domain.Interfaces
{
	public interface IRepositoryBase<T> where T : class
	{
		Task<T> InsertAsync(T entity);
		Task<T> UpdateAsync(T entity);
		bool Remove(int Id);
		T Select(int Id);
		IList<T> SelectAll();
		IList<T> Search(Func<T, bool> criteria);
		IList<T> SelectLastPersons();
	}
}
