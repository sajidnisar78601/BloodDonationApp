using BloodDonationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BloodDonationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public IEnumerable<Donor> Donors { get => GetDonors(); }
        public SearchPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private IEnumerable<Donor> GetDonors()
        {

            return new List<Donor> {

                new Donor{ ID = 1, AreaID = 1,
                    BloodGroupID = 1, Age="25 years", Name="Abdullah Abdullah",
                    Image="heeledShoe.png",
                    Area = new Area{ ID = 1, Name = "Peshawar" },
                    BloodGroup = new BloodGroup { ID=1, Name = "A POSITIVE" }
                },
                 new Donor{ ID = 1, AreaID = 1,
                    BloodGroupID = 1, Age="25 years", Name="Abdullah Abdullah",
                    Image="heeledShoe.png",
                    Area = new Area{ ID = 1, Name = "Peshawar" },
                    BloodGroup = new BloodGroup { ID=1, Name = "A POSITIVE" }
                }

            };
        }

        private void FavouriteButton_Clicked(object sender, EventArgs e)
        {
            var favButton = sender as ImageButton;
            favButton.Source = ImageSource.FromFile(@"heart.png");

        }
    }
}