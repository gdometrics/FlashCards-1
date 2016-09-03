using System;
using System.IO;
using FlashCards.DAL;

namespace FlashCards.DB
{
	public abstract class DatabaseConnectionProvider : IDatabaseConnectionProvider
	{

		#region <<   Constructors    >>
		public DatabaseConnectionProvider(string dbPath, string dbName)
		{
			if (string.IsNullOrEmpty(dbPath))
			{
				throw new ArgumentNullException(nameof(dbPath), "The DB Path can't be null."); 
			}
			if (string.IsNullOrEmpty(dbName))
			{
				throw new ArgumentNullException(nameof(dbName), "The DB name can't be null.");
			}

			DBName = dbName;
			DBPath = dbPath;
			DBFullPath = Path.Combine(dbPath, dbName);
		}
		#endregion

		#region <<   Properties   >>
		public string DBName
		{
			get;
			private set;
		}

		public string DBPath
		{
			get;
			private set;
		}

		public string DBFullPath
		{
			get;
			private set;
		}
		#endregion

		#region <<   Methods   >>
		public abstract IAppDBConnection GetNewConnection();
		#endregion
	}
}

