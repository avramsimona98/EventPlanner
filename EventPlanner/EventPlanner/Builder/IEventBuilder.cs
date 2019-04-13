using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Builder
{
    public interface IEventBuilder
    {
        void SetStartPrice(int startPrice);
        void SetPackageType(EPackageType packageType);
        void SetLocation(string location);
        void SetEventDay(EEventDay eventDay);
        void SetEventType(EEventType eventType);
        Event GetEvent();
    }
}
