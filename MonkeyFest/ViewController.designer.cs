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

namespace MonkeyFest
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NameInput { get; set; }

        [Action ("myswchanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void myswchanged (UIKit.UISwitch sender);

        [Action ("UIButton2157_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton2157_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (NameInput != null) {
                NameInput.Dispose ();
                NameInput = null;
            }
        }
    }
}