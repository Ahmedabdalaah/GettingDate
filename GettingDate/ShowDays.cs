using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingDate
{
    internal class ShowDays
    {
        public ShowDays()
        {
            DateTime dat = Convert.ToDateTime("01/02/2022");
            for (int i = 1; i<= 7; i++)
            {
                Console.WriteLine(dat.ToString("dddd"));
                dat = dat.AddDays(1);
            }
        }
    }
}
