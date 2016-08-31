using System;
using System.Collections.Generic;
namespace FlashCards.DAL
{
	public interface IRepository<TEntity> : IDisposable where TEntity : new()
	{
		OperationResult Save(TEntity entity);
		void Delete(TEntity entity);
		OperationResult<TEntity> Find(int id);
		List<TEntity> FindAll();
	}
}