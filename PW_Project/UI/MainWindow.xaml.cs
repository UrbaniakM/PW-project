using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//dlls
using Urbaniak.PW_project.BL;
using Urbaniak.PW_project.UI.ViewModels;

namespace Urbaniak.PW_project.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BusinessLogic businessLogic;
        private ProductsListViewModel productsViewModel;
        private ProducersListViewModel producersViewModel;

        private void SwitchView(object sender, RoutedEventArgs args)
        {
            MenuItem obj = sender as MenuItem;
            if(obj.Name.Equals("Producers"))
            {
                DataContext = producersViewModel;
                this.Title = "Producers";
            }
            else
            {
                DataContext = productsViewModel;
                this.Title = "Products";
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            Properties.Settings settings = new Properties.Settings();
            businessLogic = new BusinessLogic(settings.DAO_dll_location);

            productsViewModel = new ProductsListViewModel(businessLogic.ProductsBL);
            producersViewModel = new ProducersListViewModel(businessLogic.ProducentsBL);

            DataContext = productsViewModel;
            this.Title = "Products";
        }

        
    }
}
