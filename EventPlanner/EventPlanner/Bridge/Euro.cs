using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Bridge
{
    class Euro : IConvertorServices
    {
        public void MoneyConvert(float money)
        {
            Console.WriteLine((money / 4.77).ToString("0.00") + " Euro");
        }
    }
}
