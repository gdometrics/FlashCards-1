using System;
using FlashCards.DAL;
using FlashCards.iOS.DAL;
using System.IO;
using SQLite;
namespace FlashCards
{
	public static class iOSDatabaseConnectionProvider
	{

		#region <<   Private Members And Constants   >>

		public static readonly string DBName = "FlashCards.db";
		private static string _dbPath;

		public static string DBPath{
			get
			{
				if (string.IsNullOrEmpty(_dbPath))
				{
					return string.Empty;
				}
				return _dbPath;
			}
			private set
			{
				_dbPath = value;
			}
		}
		#endregion

		#region <<   Constructors   >>
		static iOSDatabaseConnectionProvider()
		{

		}
		#endregion

		#region << Public Static Methods >>
		public static IAppDBConnection GetNewConnection(string folderPath)
		{
			DBPath = Path.Combine(folderPath, DBName);
			var connection = new SQLiteConnection(DBPath);
			return new iOSQLiteDBConnection(connection);
		}

		#endregion
	}
}