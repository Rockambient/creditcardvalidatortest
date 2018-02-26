// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CreditCardValidator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CrashTest { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CreditCardTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ErrorMessagesTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ValidateButton { get; set; }

        [Action ("CrashTest_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CrashTest_TouchUpInside (UIKit.UIButton sender);

        [Action ("ValidateButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ValidateButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CrashTest != null) {
                CrashTest.Dispose ();
                CrashTest = null;
            }

            if (CreditCardTextField != null) {
                CreditCardTextField.Dispose ();
                CreditCardTextField = null;
            }

            if (ErrorMessagesTextField != null) {
                ErrorMessagesTextField.Dispose ();
                ErrorMessagesTextField = null;
            }

            if (ValidateButton != null) {
                ValidateButton.Dispose ();
                ValidateButton = null;
            }
        }
    }
}