using LiveStockApp.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LiveStockApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private DatabaseService _databaseService;

        public MainPage()
        {
            InitializeComponent();
            _databaseService = new DatabaseService("Livestock.db");
            LoadLivestock();
        }

        private async void LoadLivestock()
        {
            var livestockList = await _databaseService.GetLivestockAsync();
            LivestockList.ItemsSource = livestockList;
        }
    }
}
