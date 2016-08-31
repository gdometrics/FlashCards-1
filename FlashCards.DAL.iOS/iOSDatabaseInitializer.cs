using System;
using FlashCards.DAL;
using FlashCards.DB;
using FlashCards.Models;
using SQLite;
namespace FlashCards.iOS.DB
{
	public class iOSDatabaseInitializer : IDatabaseInitializer
	{
		IAppDBConnection _connection = null;

		public iOSDatabaseInitializer(IAppDBConnection conn)
		{
			if (conn == null)
			{
				throw new ArgumentNullException(nameof(conn), "Connection can't be null");
			}
			_connection = conn;
		}

		public void SetupDB()
		{
			
			_connection.CreateTable<AppObject>();
		}


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