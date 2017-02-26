using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterApp.Models
{
    public class Contractor
    {
        public int ContractorID { get; set; }
        public string CompanyName { get; set; }         //nazwa firmy
        public string NIP { get; set; }                 //nip    
        public DateTime DateOfContract { get; set; }    //umowa do kiedy
        public DateTime DateOfAppointment { get; set; } //data spotkania
        public string OthersInfo { get; set; }          //uwagi
        public virtual User WhoCreated { get; set; }            //użytkownik wprowadzający
        public int? WhoCreatedUserID { get; set; }
        public string TelNumber { get; set; }           //telefon
        public string Voivodeship { get; set; }         //województwo
        public string Tariff { get; set; }              //taryfa
        public string Adress { get; set; }              //adres
        public DateTime Contact { get; set; }           //kontakt(kiedy)
        public DateTime LaunchDate { get; set; }        //data wprowadzenia

        public string WhoCreatedName { get; set; }
    }
}
