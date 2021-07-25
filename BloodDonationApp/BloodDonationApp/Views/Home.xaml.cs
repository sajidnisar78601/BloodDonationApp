using BloodDonationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BloodDonationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private Timer timer;
        public List<Banner> Banners { get => GetBanners(); }
        public List<Product> CollectionsList { get => GetCollections(); }
        public List<Area> AreaList { get => GetAreas(); }

        //New implementation
        public IEnumerable<BloodGroup> BloodGroups { get => GetBloodGroups(); }

        private IEnumerable<BloodGroup> GetBloodGroups()
        {
            return new List<BloodGroup> {
                new BloodGroup { ID = 1, Name = "A POSITIVE"},
                new BloodGroup { ID = 2, Name = "A NEGATIVE"},
                new BloodGroup { ID = 3, Name = "B POSITIVE"},
                new BloodGroup { ID = 4, Name = "B NEGATIVE"},
                new BloodGroup { ID = 5, Name = "AB POSITIVE"},
                new BloodGroup { ID = 6, Name = "AB NEGATIVE"},
                new BloodGroup { ID = 7, Name = "O POSITIVE"},
                new BloodGroup { ID = 8, Name = "O NEGATIVE"},
            };
        }

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "SUMMER COLLECTION", Message = "40% Discount", Caption = "BEST DISCOUNT THIS SEASON", Image = "classic.png" });
            bannerList.Add(new Banner { Heading = "WOMEN'S CLOTHINGS", Message = "UP TO 50% OFF", Caption = "GET 50% OFF ON EVERY ITEM", Image = "womenCol.png" });
            bannerList.Add(new Banner { Heading = "ELEGANT COLLECTION", Message = "20% Discount", Caption = "UNIQUE COMBINATIONS OF ITEMS", Image = "elegantCol.png" });
            return bannerList;
        }

        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "floral.png", Name = "Floral Bag + Hat", Price = "$123.50" });
            trendList.Add(new Product { Image = "satchel.png", Name = "Satchel Bag", Price = "$49.99" });
            trendList.Add(new Product { Image = "leatherBag.png", Name = "Leather Bag", Price = "$40.99" });
            return trendList;
        }

        private List<Area> GetAreas()
        {
            var colList = new List<Area>();
            colList.Add(new Area { Image = "photo_2.png", Name = "Karachi" });
            colList.Add(new Area { Image = "photo_2.png", Name = "Lahore"});
            colList.Add(new Area { Image = "photo_2.png", Name = "Islamabad" });
            colList.Add(new Area { Image = "photo_2.png", Name = "Peshawar" });
            colList.Add(new Area { Image = "photo_2.png", Name = "Hyderabad" });
            colList.Add(new Area { Image = "photo_2.png", Name = "Faislabad" });
            return colList;
        }

        protected override void OnAppearing()
        {
            //timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            //timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Device.BeginInvokeOnMainThread(() =>
            //{

            //    if (cvBanners.Position == 2)
            //    {
            //        cvBanners.Position = 0;
            //        return;
            //    }

            //    cvBanners.Position += 1;
            //});
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
            //var parentPage = this.Parent as TabbedPage;
            //parentPage.SelectedItem = new SearchBar();


        }

        private async void Area_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }
    }

    public class Banner
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}