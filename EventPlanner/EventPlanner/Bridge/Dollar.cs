using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Bridge
{
    class Dollar : IConvertorServices
    {
        public void MoneyConvert(float money)
        {
            Console.WriteLine((money / 4.21).ToString("0.00") + " Dollar");
        }
    }
}
