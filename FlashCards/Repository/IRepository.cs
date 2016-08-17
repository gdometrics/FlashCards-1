using System;
using System.Collections.Generic;
namespace FlashCards.Repository
{
	public interface IRepository<TEntity> : IDisposable where TEntity : class
	{
		OperationResult Save(TEntity entity);
		void Delete(TEntity entity);
		TEntity Find(int id);
		List<TEntity> FindAll();
	}
}