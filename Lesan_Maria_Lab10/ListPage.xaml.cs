using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lesan_Maria_Lab10.Models;

namespace Lesan_Maria_Lab10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        //Await specifica compilatorului ca undeva in metoda pe care o apelam,
    //    o parte din cod se va executa pe un fir de executie din background
//utilizand un task si sa astepte rularea restului de cod din metoda pana
//cand metoda marcata await termina ce are de facut
//• Intre timp, thread-ul curent poate procesa cealalta parte a codului si
//dupa finalizarea executiei metodei marcate cu await se executa si
//cealalta parte
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShopList)BindingContext;
            slist.Date = DateTime.UtcNow;
            await App.Database.SaveShopListAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)  //• Async – prescurtarea de la asynchronous—se pot executa mai multe actiuni simultan(cod multithreaded – cod asynchron)
        {
            var slist = (ShopList)BindingContext;
            await App.Database.DeleteShopListAsync(slist);
            await Navigation.PopAsync();   //pagina nemodala - navigare la pag anterioara
        }
        async void OnChooseButtonClicked(object sender, EventArgs e)
        {
            //pagina nemodala - navigare ierarhica, utilizam proprietatea Navigation a obiectului Pagina
            await Navigation.PushAsync(new ProductPage((ShopList) this.BindingContext)    
            {
                BindingContext = new Product()
            });

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var shopl = (ShopList)BindingContext;

            listView.ItemsSource = await App.Database.GetListProductsAsync(shopl.ID);
        }
    }
}