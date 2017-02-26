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
using System.Windows.Shapes;
using CallCenterApp.Common;
using CallCenterApp.Controllers;
using System.Data;
using System.Collections;

namespace CallCenterApp.Views
{
    /// <summary>
    /// Interaction logic for CallCenterWindow.xaml
    /// </summary>
    public partial class CallCenterWindow : Window
    {
        public CallCenterWindow()
        {
            InitializeComponent();

            if (!SessionController.User.IsAdmin) GridColumnWhoCreated.Visibility = Visibility.Hidden;
            contractorsController = new ContractorsController();
            contractorController = new ContractorController(Enums.WindowType.Delete);
            usersController = new UsersController();

            DataContext = contractorsController;
            if (!SessionController.User.IsAdmin) {
                buttonUsers.Visibility = Visibility.Hidden;
            }
        }




        public ContractorsController contractorsController;

        public ContractorController contractorController;

        public UsersController usersController;

        private void DataGridWarehouse_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (SelectedWarehouseId == null && warehousesController.SelectedWarehouse != null)
            //{
            //    var type = "WarehouseShow";
            //    if (Cache.WindowCache[type] == null)
            //    {
            //        OpenWindow(type, Helper.Enum.WindowTypes.Show, warehousesController.SelectedWarehouse.Id);
            //        ((Magazyn)Cache.WindowCache[type]).Closed += delegate { RefreshDataGrid(); Cache.WindowCache[type] = null; };
            //    }
            //    ((Magazyn)Cache.WindowCache[type]).Show();
            //    ((Magazyn)Cache.WindowCache[type]).Activate();
            //}
            //else if (warehousesController.SelectedWarehouse != null)
            //{
            //    //WTF?
            //    SelectedWarehouseId = warehousesController.SelectedWarehouse.Id;
            //    var targetWindow = Window.GetWindow(this);
            //    targetWindow.Close();
            //}

        }
        private Contractor ContractorWindow;
        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (ContractorWindow == null)
            {
                ContractorWindow = new Contractor(Enums.WindowType.Create);
                ContractorWindow.Show();
                ContractorWindow.Closed += delegate { ContractorWindow = null; contractorsController.RefreshDataGrid(ref dataGridContractors); };
            }
            ContractorWindow.Show();
            ContractorWindow.Activate();
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (contractorsController.SelectedContractor != null)
            {
                if (ContractorWindow == null)
                {
                    ContractorWindow = new Contractor(Enums.WindowType.Edit, contractorsController.SelectedContractor.ContractorID);
                    ContractorWindow.Show();
                    ContractorWindow.Closed += delegate { ContractorWindow = null; contractorsController.RefreshDataGrid(ref dataGridContractors); };
                }
                ContractorWindow.Show();
                ContractorWindow.Activate();
            }
        }

        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {
            if (contractorsController.SelectedContractor != null)
            {
                if (ContractorWindow == null)
                {
                    ContractorWindow = new Contractor(Enums.WindowType.Show, contractorsController.SelectedContractor.ContractorID);
                    ContractorWindow.Show();
                    ContractorWindow.Closed += delegate { ContractorWindow = null; contractorsController.RefreshDataGrid(ref dataGridContractors); };
                }
                ContractorWindow.Show();
                ContractorWindow.Activate();
            }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (contractorsController.SelectedContractor != null)
            {
                contractorController.Contractor = contractorsController.SelectedContractor;
                contractorController.ContractorDo();
                contractorsController.RefreshDataGrid(ref dataGridContractors);
            }
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            contractorsController.Search();
            //dataGridContractors.ItemsSource = contractorsController.Contractors;
            contractorsController.RefreshDataGrid(ref dataGridContractors,true);
        }
        
        private Users UsersWindow;
        private void buttonUsers_Click(object sender, RoutedEventArgs e)
        {
            if (UsersWindow == null)
            {
                UsersWindow = new Users();
                UsersWindow.Show();
                UsersWindow.Closed += delegate { UsersWindow = null; };
            }
            UsersWindow.Show();
            UsersWindow.Activate();
        }


        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            contractorsController.Highlight(ref dataGridContractors);
        }

        public void Highlight()
        {
            var itemsSource = dataGridContractors.ItemsSource as IEnumerable;
            foreach (var item in itemsSource)
            {
                var row = dataGridContractors.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                var date = ((Models.Contractor)row.Item).Contact.Date;
                if (date.Year == DateTime.Now.Year && date.Day == DateTime.Now.Day && date.Month == DateTime.Now.Month)
                {
                    row.Background = Brushes.GreenYellow;
                }
            }
        }
    }
}
