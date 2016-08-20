using System;
using FlashCards.DAL;
using FlashCards.iOS.DAL;
using System.IO;
using SQLite;
namespace FlashCards
{
	public static class iOSDatabaseConnectionProvider
	{

		public static readonly string DBName = "FlashCards.db";

		public static string DBPath{
			get;
			private set;
		} 

		public static IAppDBConnection GetNewConnection()
		{
			var connection = new SQLiteConnection(DBPath);
			Console.WriteLine("DB Path:" + DBPath);
			return new iOSQLiteDBConnection(connection);
		}

		static iOSDatabaseConnectionProvider()
		{
			var folderPath =  Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			DBPath = Path.Combine(folderPath, DBName);
		}

	}
}