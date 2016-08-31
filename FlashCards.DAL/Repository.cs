using System;
using System.Collections.Generic;

namespace FlashCards.DAL
{
	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : new()
	{
		protected IAppDBConnection _connection;

		#region << Constructors >>

		public Repository(IAppDBConnection connection)
		{
			if (connection == null)
			{
				throw new ArgumentNullException(nameof(connection), "The connection can't be null");
			}
			_connection = connection;
		}
		#endregion

		#region << Public Methods >>

		public abstract void Delete(TEntity entity);

		public abstract OperationResult<TEntity> Find(int id);

		public abstract List<TEntity> FindAll();

		public abstract OperationResult Save(TEntity entity);

		#endregion

		#region << Dispose >>

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (_connection != null)
				{
					_connection.Dispose();
				}
			}
		}
		#endregion
	}
}