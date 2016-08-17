using System;
using SQLite;
namespace FlashCards.Models
{
	public class AppObject : IAppObject
	{

		#region << Constructors >>

		public AppObject()
		{
			this.Id = 0;
			this.Name = string.Empty;
			this.Description = string.Empty;
		}
		#endregion

		#region << Properties >>
		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get;
			internal set;
		}

		public string Name
		{
			get;
			internal set;
		}

		public string Description
		{
			get;
			internal set;
		}

		#endregion
	}
}