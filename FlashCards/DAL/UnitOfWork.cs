using System;
using FlashCards.iOS.DAL;
using FlashCards.Models;
namespace FlashCards.DAL
{
	public abstract class UnitOfWork : IDisposable
	{

		private bool _dispose;

		public UnitOfWork()
		{
			_dispose = false;
		}

		public abstract void Save();


		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_dispose)
			{
				if (disposing)
				{
					//Dispose here
				}
			}
			this._dispose = true;
		}

	}
}