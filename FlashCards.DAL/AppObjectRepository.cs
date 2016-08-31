using System;
using System.Collections.Generic;
using FlashCards.DAL;
using FlashCards.Models;
namespace FlashCards.DAL
{
	public class AppObjectRepository : Repository<AppObject>
	{

		#region << Constructors >>

		public AppObjectRepository(IAppDBConnection connection)
		: base(connection)
		{ }
		#endregion

		#region << Public Methods >>
		public override void Delete(AppObject entity)
		{
			throw new NotImplementedException();
		}

		public override OperationResult<AppObject> Find(int id)
		{
			try
			{
				return _connection.Get<AppObject>(id);
			}
			catch (Exception)
			{
				throw;
			}
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
					return _connection.Save(entity);
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