using System;
using System.IO;
using FlashCards.DAL;
namespace FlashCards.DB.Mac
{
	public class MacDatabaseConnectionProvider : DatabaseConnectionProvider
	{

		#region <<   Constructors   >>
		public MacDatabaseConnectionProvider(string dbPath, string dbName)
		: base (dbPath, dbName)
		{   }


		#endregion

		#region << Public Static Methods >>
		public override IAppDBConnection GetNewConnection()
		{//TODO: CONTINUE HERE, I NEED TO IMPLEMENT SQLITE FROM https://developer.xamarin.com/guides/mac/application_fundamentals/databases/
			throw new NotImplementedException();
			//var connection = new SQLiteConnection(DBFullPath);
			//return new iOSQLiteDBConnection(connection);
		}

		#endregion
	}
}

