using EventPlanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Decorater
{
   public interface IEvent
    {
        EPackageType PType { get; set; }
        EEventType EType { get; set; }
        EEventDay DType { get; set; }
        ELocation LType { get; set; }
        int Price { get; set; }
        void SetPrice();
        string ToString();

    }
}
