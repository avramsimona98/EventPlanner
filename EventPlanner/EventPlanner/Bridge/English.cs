using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Bridge
{
    class English : IConvertorServices
    {
        public void ConvertToEuro(float money)
        {
            Console.WriteLine((money / 4.76).ToString("0.00") + " EURO");
        }
        public void ConvertToDollar(float money)
        {
            Console.WriteLine((money / 4.21).ToString("0.00") + " DOLLAR");
        }
        public void LanguageTranslator()
        {
            Console.WriteLine("Wedding");
        }
    }
}
