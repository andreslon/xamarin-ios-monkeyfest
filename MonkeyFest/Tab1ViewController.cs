using Foundation;
using MonkeyFest.Models;
using System;
using System.Collections.Generic;
using UIKit;

namespace MonkeyFest
{
    public partial class Tab1ViewController : UIViewController
    {
        public Tab1ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad(); 
            LoadTable(); 
        } 
        async private void LoadTable()
        {
            var firebaseRepository = new FirebaseRepository();
            var cars = await firebaseRepository.GetCarsAsync();

            List<string> list = new List<string>
            {
                "Andres", "Juan","Pedro","Pablo","Ismael"
            }; 
            MyTable.Source = new MyTableViewSource(cars);
            MyTable.ReloadData();
        }
    }
}