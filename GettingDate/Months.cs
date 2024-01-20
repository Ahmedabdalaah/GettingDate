using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingDate
{
    internal class Months
    {
        public Months()
        {
            DateTime dat = Convert.ToDateTime("01/01/2000");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(dat.ToString("MMMM"));
                dat = dat.AddMonths(1);
            }
        }
    }
}
