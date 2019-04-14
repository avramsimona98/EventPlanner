using EventPlanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Builder
{
    public class EventBuilder : IEventBuilder
    {
        private Event eveniment;
        public EventBuilder()
        {
            eveniment = new Event();
        }
        public void SetStartPrice(int startPrice)
        {
            eveniment.StartPrice = startPrice;
        }

        public void SetPackageType(EPackageType packageType)
        {
            eveniment.PackageType = packageType;
        }

        public void SetLocation(ELocation location)
        {
            eveniment.Location = location;
        }

        public void SetEventDay(EEventDay eventDay)
        {
            eveniment.EventDay = eventDay;
        }

        public void SetEventType(EEventType eventType)
        {
            eveniment.EventType = eventType;
        }

        public Event GetEvent()
        {
            return eveniment;
        }
    }
}
