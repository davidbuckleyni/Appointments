using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DataAccess.Xamarin.Forms_EFCore.Helpers;
using Foundation;
using UIKit;

namespace BookingApp.iOS.Helpers
{
    class DatabasePath : IDBPath
    {


        public string GetDbPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "EFCoreDB.db");
        }
    }
}