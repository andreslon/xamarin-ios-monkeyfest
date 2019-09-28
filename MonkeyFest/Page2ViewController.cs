using Foundation;
using System;
using UIKit;

namespace MonkeyFest
{
    public partial class Page2ViewController : UIViewController
    {
        public string Name { get; set; }
        public Page2ViewController (IntPtr handle) : base (handle)
        {

            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NameOutput.Text = Name;
        }
    }
}