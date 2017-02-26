using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CallCenterApp.Common;
using CallCenterApp.Services;
using CallCenterApp.Models;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace CallCenterApp.Controllers
{
    public class ContractorsController
    {
        private int oldContractorID;
        private Contractor selectedContractor = new Contractor();
        public Contractor SelectedContractor
        {
            get { return selectedContractor; }
            set
            {
                selectedContractor = value;
                if(value!=null) oldContractorID = value.ContractorID;
            }
        }

        private ObservableCollection<Contractor> contractors = new ObservableCollection<Contractor>();
        public ObservableCollection<Contractor> Contractors
        {
            get { return contractors; }
        }



        private ContractorService contractorService;

        public ContractorsController()
        {
            contractorService = new ContractorService();

            GetContractors();

            selectedSearchCriteria = searchCriterias.FirstOrDefault();
        }

        public void GetContractors()
        {
            contractors = new ObservableCollection<Contractor>(contractorService.GetContractors().Result);
        }


        public void RefreshDataGrid(ref DataGrid dataGrid, bool search = false)
        {
            if(!search)
            GetContractors();
            bool find = false;

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = contractors;
            dataGrid.Items.Refresh();
            dataGrid.UpdateLayout();

            foreach (Contractor contractor in contractors)
            {
                if (contractor.ContractorID == oldContractorID) { dataGrid.SelectedItem = contractor; find = true; }
            }
            if (!find) dataGrid.SelectedIndex = 0;


            dataGrid.Focus();
            Highlight(ref dataGrid);
        }

        private string searchCriteria;
        public string SearchCriteria
        {
            get { return searchCriteria; }
            set { searchCriteria = value; }
        }

        private List<string> searchCriterias = new List<string> { "NIP", "Nazwa firmy"};
        public List<string> SearchCriterias
        {
            get { return searchCriterias; }
        }

        private string selectedSearchCriteria;
        public string SelectedSearchCriteria
        {
            get { return selectedSearchCriteria; }
            set { selectedSearchCriteria = value; }
        }



        public void Search()
        {
            if(!string.IsNullOrEmpty(SelectedSearchCriteria))
            {
                contractors = string.IsNullOrEmpty(searchCriteria) ? new ObservableCollection<Contractor>(contractorService.GetContractors().Result) : new ObservableCollection<Contractor>(contractorService.GetContractors(searchCriteria,selectedSearchCriteria).Result);
            }
            else
            {
                System.Windows.MessageBox.Show("Uzupełnij parametry wyszukiwania");
            }
        }

        public void Highlight(ref DataGrid datagrid)
        {
            if (datagrid.ItemsSource != null)
            {
                var itemsSource = datagrid.ItemsSource as IEnumerable;
                foreach (var item in itemsSource)
                {
                    var row = datagrid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                    var date = ((Contractor) row.Item).Contact.Date;
                    if (date.Year == DateTime.Now.Year && date.Day == DateTime.Now.Day &&
                        date.Month == DateTime.Now.Month)
                    {
                        row.Background = Brushes.GreenYellow;
                    }
                }
            }
        }
    }
}
