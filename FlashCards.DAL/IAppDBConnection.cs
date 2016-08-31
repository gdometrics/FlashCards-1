using System;
namespace FlashCards.DAL
{
	/// <summary>
	/// This interface will help us to remove SQLite dependency to implement fake DB connection provider
	/// </summary>
	public interface IAppDBConnection : IDisposable
	{
		OperationResult Save<T>(T item);
		OperationResult<T> Get<T>(int id) where T : new();
		void CreateTable<T>() where T : class; 
	}
}