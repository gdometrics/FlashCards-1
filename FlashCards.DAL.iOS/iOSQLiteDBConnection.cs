using System;
using FlashCards.DAL;
using SQLite;
namespace FlashCards.iOS.DAL
{
	public class iOSQLiteDBConnection : IAppDBConnection
	{
		private SQLiteConnection _connection;

		public iOSQLiteDBConnection(SQLiteConnection connection)
		{
			if (connection == null)
			{
				throw new  ArgumentNullException(nameof(connection),"There is an error accessing DB connection.");
			}
			_connection = connection;
		}

		public void CreateTable<T>() where T :class
		{
			_connection.CreateTable<T>(CreateFlags.AllImplicit);
		}



		public OperationResult<T> Get<T>(int id) where T :new() 
		{
			OperationResult<T> result = new OperationResult<T>();
			try
			{
				T item = _connection.Get<T>(id);
				if (item != null)
				{
					result.ResultObject = item;
					result.IsSuccess = true;
				}
				else{
					result.IsSuccess = false;
					result.Feedback = "Item not found.";
				}
			}catch(Exception)
			{
				throw;
			}
			return result;
		}

		public OperationResult Save<T>(T item)
		{
			OperationResult result = new OperationResult();
			try
			{
				_connection.Insert(item);
				result.IsSuccess = true;

			}
			catch (Exception)
			{
				result.IsSuccess = false;
				result.Feedback = "Item not saved";
			}
			return result;
		}

		public void Dispose()
		{//TODO: IMPLEMENT FULL DISPOSABLE PATTERN
			_connection.Dispose();
		}
	}
}

