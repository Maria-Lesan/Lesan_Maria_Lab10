using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lesan_Maria_Lab10
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppMasterDetailPageDetail : ContentPage
    {
        public AppMasterDetailPageDetail()
        {
            InitializeComponent();
            var image = new Image { Source = "om.jpeg" };
        }
    }
}