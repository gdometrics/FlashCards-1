using System;
using System.Collections.Generic;
using FlashCards;
using FlashCards.Models;
using SQLite;
namespace FlashCards.iOS.Repository
{
	public class AppObjectRepository : iOSRepository<AppObject>
	{

		#region << Constructors >>

		public AppObjectRepository(SQLiteConnection connection)
		: base(connection)
		{ }
		#endregion

		#region << Public Methods >>
		public override void Delete(AppObject entity)
		{
			throw new NotImplementedException();
		}

		public override AppObject Find(int id)
		{
			AppObject item = null;
			try
			{
				item = _connection.Get<AppObject>(id);
			}
			catch (Exception)
			{
				throw;
			}
			return item;
		}

		public override List<AppObject> FindAll()
		{
			throw new NotImplementedException();
		}

		public override OperationResult Save(AppObject entity)
		{
			OperationResult result = new OperationResult();
			try
			{
				if (entity != null)
				{
					_connection.Insert(entity);
					result.IsSuccess = true;
			}
			}
			catch(Exception)
			{
				result.IsSuccess = false;
				result.Feedback = "Error saving AppObject";
			}
			return result;
		}

		#endregion

	}
}