using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using CallCenterApp.Common;
using CallCenterApp.Services;
using CallCenterApp.Models;

namespace CallCenterApp.Controllers
{
    public class ContractorController
    {
        private Contractor contractor = new Contractor();
        public Contractor Contractor
        {
            get { return contractor; }
            set { contractor = value; }
        }




        private ContractorService contractorService;
        private Enums.WindowType windowType;

        public ContractorController(Enums.WindowType windowType, [Optional] int contractorId)
        {
            this.windowType = windowType;

            contractorService = new ContractorService();

            if (windowType == Enums.WindowType.Create)
            {
                Contractor.DateOfAppointment = DateTime.Now;
                Contractor.DateOfContract = DateTime.Now;
                Contractor.Contact = DateTime.Now;
                Contractor.LaunchDate = DateTime.Now;
            }
            else if (windowType == Enums.WindowType.Edit || windowType == Enums.WindowType.Show)
            {
                Contractor = contractorService.GetContractor(contractorId).Result;
            }
        }

        private bool Validate()
        {
            var result = Validators.ValidateNIP(contractor.NIP);
            if (result.Item1) { contractor.NIP = result.Item2; return true; }
            else { MessageBox.Show("Nieprawidłowy NIP"); return false; }
        }

        public bool ContractorDo()
        {
            if (windowType == Enums.WindowType.Create && Validate())
            {
                return contractorService.CreateContractor(Contractor).Result.ContractorID > 0;
            }
            else if (windowType == Enums.WindowType.Edit && Validate())
            {
                contractorService.UpdateContractor(Contractor);
                return true;
            }
            else if (windowType == Enums.WindowType.Delete)
            {
                contractorService.DeleteContractor(Contractor.ContractorID);
                return true;
            }
            return false;
        }
    }
}
