using System;
using FlashCards.DAL;

using FlashCards.Models;
namespace FlashCards.DAL
{
	public class UnitOfWork : IDisposable
	{

		private bool _dispose;
		private Repository<AppObject> _appObjectRepository;
		private DAL.IAppDBConnection _connection;

		public Repository<AppObject> ApplicationObjectRepository
		{
			get
			{
				if (_appObjectRepository == null)
				{
					_appObjectRepository = new AppObjectRepository(_connection);
				}
				return _appObjectRepository;
			}
		}


		public UnitOfWork(IAppDBConnection dbConnection)
		{
			if (dbConnection == null)
			{
				throw new ArgumentNullException(nameof(dbConnection), "Error getting the connection.");
			}
			_connection = dbConnection;
			_dispose = false;
		}

	//	public abstract void Save();


		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_dispose)
			{
				if (disposing)
				{
					if (_connection != null)
					{
						_connection.Dispose();	
					}
				}
			}
			this._dispose = true;
		}

	}
}