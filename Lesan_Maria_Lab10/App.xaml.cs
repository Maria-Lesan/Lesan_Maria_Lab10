using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lesan_Maria_Lab10.Data;
using System.IO;

namespace Lesan_Maria_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }
        public App()              //Este responsabila pentru instantierea primei pagini care va fi afisata de aplicatie pe fiecare platforma
        {
            InitializeComponent();
            MainPage = new AppMasterDetailPage();

            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
