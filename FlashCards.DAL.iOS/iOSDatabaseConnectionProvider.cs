using System;
using FlashCards.DAL;
using FlashCards.iOS.DAL;
using System.IO;
using SQLite;
using FlashCards.DB;

namespace FlashCards.DB.iOS
{
	public class iOSDatabaseConnectionProvider : DatabaseConnectionProvider
	{

		#region <<   Constructors   >>
		public iOSDatabaseConnectionProvider(string dbPath, string dbName)
		: base(dbPath, dbName)
		{   }


		#endregion

		#region << Public Methods >>
		public override IAppDBConnection GetNewConnection()
		{
			var connection = new SQLiteConnection(DBFullPath);
			return new iOSQLiteDBConnection(connection);
		}

		#endregion
	}
}