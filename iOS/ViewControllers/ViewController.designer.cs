// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FlashCards.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFlashCards { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnReadingComprehension { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSettings { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationItem navItem { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnFlashCards != null) {
                btnFlashCards.Dispose ();
                btnFlashCards = null;
            }

            if (btnReadingComprehension != null) {
                btnReadingComprehension.Dispose ();
                btnReadingComprehension = null;
            }

            if (btnSettings != null) {
                btnSettings.Dispose ();
                btnSettings = null;
            }

            if (navItem != null) {
                navItem.Dispose ();
                navItem = null;
            }
        }
    }
}