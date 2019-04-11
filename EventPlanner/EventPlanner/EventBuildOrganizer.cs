using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    class EventBuildOrganizer
    {
        private IEventBuilder eventBuilder;
        public EventBuildOrganizer(IEventBuilder builder)
        {
            eventBuilder = builder;
        }
        public void Construct(int guests, EPackageType packageType, ELocation location, EEventDay eventDay, EEventType eventType)
        {
            eventBuilder.SetGuests(guests);
            eventBuilder.SetPackageType(packageType);
            eventBuilder.SetLocation(location);
            eventBuilder.SetEventDay(eventDay);
            eventBuilder.SetEventType(eventType);
        }
        public Event GetResult()
        {
            return eventBuilder.GetEvent();
        }
    }
}
