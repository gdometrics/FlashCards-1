using System;
using System.Collections.Generic;
using FlashCards.Models;
using FlashCards.Repository;
using SQLite;

namespace FlashCards.iOS.Repository
{
	public abstract class iOSRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected SQLiteConnection _connection;

		#region << Constructors >>

		public iOSRepository(SQLiteConnection connection)
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

		public abstract TEntity Find(int id);

		public abstract List<TEntity> FindAll();

		public abstract OperationResult Save(TEntity entity);

		#endregion

		#region << Dispose >>

		public void Dispose(){
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