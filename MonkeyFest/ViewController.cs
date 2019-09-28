using Foundation;
using System;
using UIKit;

namespace MonkeyFest
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var page2 = segue.DestinationViewController as Page2ViewController;
            if (page2!=null)
            {
                page2.Name = NameInput.Text;
            }
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton2157_TouchUpInside(UIButton sender)
        {
            //Create Alert
            var okAlertController = UIAlertController.Create("Title", NameInput.Text, UIAlertControllerStyle.Alert);

            //Add Action
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            // Present Alert
            PresentViewController(okAlertController, true, null);
        }

       async partial void myswchanged(UISwitch sender)
        {
            NameInput.Text = sender.On ? "TRUE" : "FALSE";

            
        }
    }
}