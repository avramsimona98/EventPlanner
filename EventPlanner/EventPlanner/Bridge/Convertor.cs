using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Bridge
{
    class Convertor : IConvertor
    {
        private IConvertorServices service { get; set; }

        public Convertor(IConvertorServices Service)
        {
            service = Service;
        }
        public void MoneyConvert(float money)
        {
            service.MoneyConvert(money);
        }
    }
}
