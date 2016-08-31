using System;
namespace FlashCards.DB
{
	public interface IDatabaseInitializer : IDisposable
	{
		void SetupDB();
	}
}