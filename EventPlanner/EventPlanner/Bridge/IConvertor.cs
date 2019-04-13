using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Bridge
{
    public interface IConvertor
    {
        void ConvertToEuro(float money);
        void ConvertToDollar(float money);
        void LanguageTranslator();
    }
}
