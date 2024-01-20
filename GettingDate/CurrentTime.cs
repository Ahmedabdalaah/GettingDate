using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingDate
{
    internal class CurrentTime
    {
        public CurrentTime()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
        }
    }
}
