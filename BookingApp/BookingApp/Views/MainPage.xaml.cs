using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataAccess;
using System.Collections.Generic;
using System.IO;

namespace BookingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "EFCore.db");

               using (var db = new APContext(dbPath))
            {
            Appointments app1 = new Appointments() { id = 1, PatientName = "Gary",DateOfBirths=Convert.ToDateTime("26/07/77"),  Notes = "" };
                Appointments app2 = new Appointments() { id = 2, PatientName = "Jack", Notes = "" };
                Appointments app3 = new Appointments() { id = 3, PatientName = "Luna",Notes=""};

                List<Appointments> _appointments = new List<Appointments>() { app1, app2, app3 };
     db.Appointments.AddRange(_appointments);
              db.SaveChanges();

 }
        }
    }
}