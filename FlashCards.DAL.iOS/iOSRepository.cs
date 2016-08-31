/*
using System;
using System.Collections.Generic;
using FlashCards.DAL;

namespace FlashCards.iOS.DAL
{
	public class iOSRepository<TEntity> : Repository<TEntity> where TEntity : new()
	{


		#region << Constructors >>

		public iOSRepository(IAppDBConnection connection)
			: base(connection)
		{

		}
		#endregion

		#region << Public Methods >>

		public override void Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public override OperationResult<TEntity> Find(int id)
		{
			throw new NotImplementedException();
		}

		public override List<TEntity> FindAll()
		{
			throw new NotImplementedException();
		}

		public override OperationResult Save(TEntity entity)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region << Dispose >>

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				
			}
		}
		#endregion
	}
}
*/