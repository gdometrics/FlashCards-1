using System;
using UIKit;
using SQLite;
using System.IO;
using FlashCards.DAL;
using FlashCards.iOS.DAL;
using FlashCards.Models;
namespace FlashCards.iOS
{
	public partial class ViewController : UIViewController
	{
		
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

		partial void BtnAddAppObject_TouchUpInside(UIButton sender)
		{
			var strName = txtName.Text;
			var strDescription = txtDescription.Text;

			using(UnitOfWork uow = new UnitOfWork(iOSDatabaseConnectionProvider.GetNewConnection()))
			{
				var aObj = new AppObject();
				aObj.Name = strName;
				aObj.Description = strDescription;
				var result = uow.ApplicationObjectRepository.Save(aObj);
				if (result.IsSuccess)
				{
					lblResult.Text = "Success";
				}
				else {
					lblResult.Text = "Failure";
				}
			}
		}
	}
}
