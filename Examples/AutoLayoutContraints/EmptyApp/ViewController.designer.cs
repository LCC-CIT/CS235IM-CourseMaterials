// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace EmptyApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ChangeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HiLabel { get; set; }

        [Action ("ButtonCancel:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonCancel (UIKit.UIButton sender);

        [Action ("ChangeButtonTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ChangeButtonTouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Button2 != null) {
                Button2.Dispose ();
                Button2 = null;
            }

            if (ChangeButton != null) {
                ChangeButton.Dispose ();
                ChangeButton = null;
            }

            if (HiLabel != null) {
                HiLabel.Dispose ();
                HiLabel = null;
            }
        }
    }
}