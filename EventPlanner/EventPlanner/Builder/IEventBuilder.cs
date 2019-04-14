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
        void SetGuests();
        void SetPackageType();
        void SetLocation();
        void SetEventDay();
        void SetEventType();
        Event GetEvent();
    }
}
