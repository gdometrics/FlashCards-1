using System;
namespace FlashCards
{
	public class OperationResult<T> : OperationResult where T : new()
	{
		public OperationResult()
		{
			this.ResultObject = default(T);
		}

		public T ResultObject 
		{
			get;
			set;
		}


	}

	public class OperationResult{

		public OperationResult()
		{
			this.IsSuccess = false;
			this.Feedback = string.Empty;

		}

		public bool IsSuccess
		{
			get;
			set;
		}

		public string Feedback
		{
			get;
			set;
		}
	}
}