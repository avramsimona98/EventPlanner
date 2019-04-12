using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    class Convertor : IConvertor
    {
        public IConvertorServices service { get; set; }

        public Convertor(IConvertorServices Service)
        {
            service = Service;
        }
        public void ConvertToEuro(float money)
        {
            service.ConvertToEuro(money);
        }
        public void ConvertToDollar(float money)
        {
            service.ConvertToDollar(money);
        }
        public void LanguageTranslator()
        {
            service.LanguageTranslator();
        }
    }
}
