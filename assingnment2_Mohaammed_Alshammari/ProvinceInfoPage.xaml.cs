using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace assignment2_Mohammed_Alshammari
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadProvinces();
        }

        private void LoadProvinces()
        {
            List<Province> provinces = new List<Province>
            {
                new Province { Name= "Alberta", Capital = "Edmonton", Flag = "alberta.png" },
                new Province { Name = "British Columbia", Capital = "Victoria", Flag = "british_columbia.png" },
                new Province { Name = "Manitoba", Capital = "Winnipeg", Flag = "manitoba.png" },
                new Province { Name = "New Brunswick", Capital = "Fredericton", Flag = "new_brunswick.png" },
                new Province { Name = "Newfoundland and Labrador", Capital = "St. John's", Flag = "newfoundland_and_labrador.png" },
                new Province { Name = "Nova Scotia", Capital = "Halifax", Flag = "nova_scotia.png" },
                new Province { Name = "Ontario", Capital = "Toronto", Flag = "ontario.png" },
                new Province { Name = "Prince Edward Island", Capital = "Charlottetown", Flag = "prince_edward_island.png" },
                new Province { Name = "Quebec", Capital = "Quebec City", Flag = "quebec.png" },
                new Province { Name = "Saskatchewan", Capital = "Regina", Flag = "saskatchewan.png" }
            };

            provinceListView.ItemsSource = provinces;
        }

        private void OnProvinceSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Province selectedProvince = e.SelectedItem as Province;
                // Assuming ProvinceInfoPage is defined in the same namespace as MainPage
                Navigation.PushAsync(new ProvinceInfoPage(selectedProvince));
                provinceListView.SelectedItem = null; // Deselect the item
            }
        }
    }
}
