using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace CallCenterApp.Views
{
    /// <summary>
    /// Interaction logic for Contractor.xaml
    /// </summary>
    public partial class Contractor : Window
    {
        public Contractor(Enums.WindowType windowType, [Optional] int contractorId)
        {
            InitializeComponent();

            if (windowType == Enums.WindowType.Show || windowType == Enums.WindowType.Edit)
                contractorController = new ContractorController(windowType, contractorId);
            else
                contractorController = new ContractorController(windowType);

            DataContext = contractorController;

            if (windowType == Enums.WindowType.Show)
            {
                buttonSave.Visibility = Visibility.Hidden;
                textBoxCompanyName.IsEnabled = false;
                textBoxNip.IsEnabled = false;
                textBoxOthersInfo.IsEnabled = false;
                DatePickerDateOfAppointment.IsEnabled = false;
                DatePickerDateOfContract.IsEnabled = false;
                textBoxTelNumber.IsEnabled = false;
                textBoxVoivodeship.IsEnabled = false;
                textBoxTariff.IsEnabled = false;
                textBoxAdress.IsEnabled = false;
                DatePickerContact.IsEnabled = false;
                DatePickerLaunchDate.IsEnabled = false;
            }
        }

        public ContractorController contractorController;

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (contractorController.ContractorDo()) Close();
        }
        
    }
}
