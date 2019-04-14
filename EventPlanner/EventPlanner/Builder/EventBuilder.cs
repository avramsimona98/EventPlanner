using EventPlanner.Enum;
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
        public int guests;
        public EPackageType packageType;
        public ELocation location;
        public EEventDay eventDay;
        public EEventType eventType;

        public EventBuilder()
        {
            eveniment = new Event();
        }
        public void SetGuests()
        {
            eveniment.Guests = guests;
        }

        public void SetPackageType()
        {
            
            eveniment.PackageType = packageType;
        }

        public void SetLocation()
        {
            eveniment.Location = location;
        }

        public void SetEventDay()
        {
            eveniment.EventDay = eventDay;
        }

        public void SetEventType()
        {
            eveniment.EventType = eventType;
        }

        public Event GetEvent()
        {
            return eveniment;
        }
    }
}
