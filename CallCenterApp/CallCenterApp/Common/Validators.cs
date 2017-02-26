using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterApp.Common
{
    public static class Validators
    {
        public static Tuple<bool,string> ValidateNIP(string szNIP, bool retFormated = true)
        {
            var Result = new Tuple<bool,string>(false, szNIP);
            byte[] tab = new byte[9] { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
            byte[] tablicz = new byte[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
            int suma = 0;
            int sumcontrol = 0;

            szNIP = szNIP.Replace("-", "");
            szNIP = szNIP.Trim();

            if (szNIP.Length == 10)
            {
                foreach (char l in szNIP)
                {
                    if (Array.IndexOf(tablicz, Convert.ToByte(l)) == -1) return Result;
                }

                sumcontrol = Convert.ToInt32(szNIP[9].ToString());

                for (int i = 0; i < 9; i++)
                {
                    suma += tab[i] * Convert.ToInt32(szNIP[i].ToString());
                }

                if ((suma%11) != sumcontrol) return Result;
            }
            else return Result;


            if (retFormated)
            {
                szNIP = szNIP.Insert(8, "-")
                                .Insert(6, "-")
                                .Insert(3, "-");
            }

            return new Tuple<bool, string>(true, szNIP);
        }
    }
}
