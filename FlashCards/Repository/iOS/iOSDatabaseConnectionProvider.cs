using System;
using SQLite;
using System.IO;
namespace FlashCards
{
	public static class iOSDatabaseConnectionProvider
	{

		public static readonly string DBName = "FlashCards.db";

		public static string DBPath{
			get;
			private set;
		} 

		public static SQLiteConnection GetNewConnection()
		{
			return new SQLiteConnection(DBPath);
		}

		static iOSDatabaseConnectionProvider()
		{
			var folderPath =  Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			DBPath = Path.Combine(folderPath, DBName);
		}

	}
}