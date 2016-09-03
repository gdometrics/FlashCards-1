using System;
using FlashCards.DAL;
namespace FlashCards.DB
{
	public interface IDatabaseConnectionProvider
	{
		string DBPath { get; }
		string DBName { get; }
		string DBFullPath { get; }
		IAppDBConnection GetNewConnection();
	}
}

