using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public interface IConvertorServices
    {
        void ConvertToEuro(float money);
        void ConvertToDollar(float money);
        void LanguageTranslator();
    }
}
