using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MonkeyFest.Models
{
    public class MyTableViewSource : UITableViewSource
    { 
        private List<Car> cars;
         
        public MyTableViewSource(List<Car> cars)
        {
            this.cars = cars;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            //cell.TextLabel.Text = list[indexPath.Row];
            cell.TextLabel.Text = cars[indexPath.Row].brand;
            //cell.DetailTextLabel.Text = cars[indexPath.Row].model;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return cars.Count;
        }
    }
}
