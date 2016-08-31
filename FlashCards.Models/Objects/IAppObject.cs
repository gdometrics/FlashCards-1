using System;
namespace FlashCards.Models
{
	public interface IAppObject
	{
		int Id
		{
			get;
		}

		string Name
		{
			get;
		}

		string Description
		{
			get;
		}
	}
}

