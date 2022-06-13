using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
	public interface IRepository<TEntity> where TEntity : class
	{
		//Group 1:
		//Group 1 is for finding objects
		TEntity Get(int id);
		IEnumerable<TEntity> GetAll();
		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

		//Group 2:
		//Group 2 is for adding objects	
		void Add(TEntity entity);
		void AddRange(IEnumerable<TEntity> entities);

		//Group 3:
		//Group 3 is for removing objects
		void Remove(TEntity entity);
		void RemoveRange(IEnumerable<TEntity> entities);
	}
}
