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
        void SetGuests(int guests);
        void SetPackageType(EPackageType packageType);
        void SetLocation(ELocation location);
        void SetEventDay(EEventDay eventDay);
        void SetEventType(EEventType eventType);
        Event GetEvent();
    }
}
