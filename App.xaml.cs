// App.xaml.cs: Initializes main application component
using Microsoft.Maui.Controls;

namespace LiveStockApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell(); // Set the main navigation shell
        }
    }
}
