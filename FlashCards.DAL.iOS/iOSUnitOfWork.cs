using System;
using FlashCards.DAL;
using FlashCards.iOS.DAL;
using FlashCards.Models;
namespace FlashCards.DAL.iOS
{
	public class iOSUnitOfWork : UnitOfWork
	{

		private bool _dispose;
		private AppObjectRepository _appObjectRepository;
		//private DAL.IAppDBConnection _connection;

		/*public AppObjectRepository ApplicationObjectRepository
		{
			get
			{
				if (_appObjectRepository == null)
				{
					_appObjectRepository = new AppObjectRepository(_connection);
				}
				return _appObjectRepository;
			}
		}*/


		public iOSUnitOfWork(IAppDBConnection dbConnection)
			: base(dbConnection)
		{
			if (dbConnection == null)
			{
				throw new ArgumentNullException(nameof(dbConnection), "Error getting the connection.");
			}
		//	_connection = dbConnection;
			_dispose = false;
		}

	//	public abstract void Save();


		/*
		 public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}*/

		protected override void Dispose(bool disposing)
		{
			if (!_dispose)
			{
				if (disposing)
				{
		
				}
			}
			this._dispose = true;
		}

	}
}