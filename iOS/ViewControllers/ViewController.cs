using System;
using UIKit;
using System.IO;
using FlashCards.DAL;
using FlashCards.Models;
using FlashCards.Resources;

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
			this.SetupLocalization();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			//var nextVwCtrlr = segue.DestinationViewController as AnyViewController();
			//if(nextVwCtrlr != null) {
			//	...
			//  nextVwCtrlr.Property = "blah";
			//  ...
			//}
		}


		private void SetupLocalization()
		{
			navItem.Title = AppResources.MainPage_Title;
			btnFlashCards.SetTitle(AppResources.MainPage_FlashCardsButtonTitle, UIControlState.Normal);
			btnSettings.SetTitle(AppResources.MainPage_SettingsButtonTitle, UIControlState.Normal);
		}

		/*partial void BtnAddAppObject_TouchUpInside(UIButton sender)
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
			}*/
		}
}