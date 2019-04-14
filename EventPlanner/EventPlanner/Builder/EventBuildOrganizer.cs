using EventPlanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Builder
{
    
    public class EventBuildOrganizer
    {
        public IEventBuilder eventBuilder { get; set; }

        //private static EventBuildOrganizer _instance;

        private static readonly object padlock = new object();

        private EventBuildOrganizer()
        {

        }
        public EventBuildOrganizer(IEventBuilder builder)
        {
            eventBuilder = builder;
        }
        //public static EventBuildOrganizer Instance
        //{
        //    get
        //    {
        //        lock (padlock)
        //        {
        //            if (_instance == null)
        //            {
        //                _instance = new EventBuildOrganizer();
        //            }
        //            return _instance;
        //        }
        //    }
        //}
        public void Construct(int startPrice,int guests, EPackageType packageType, ELocation location, EEventDay eventDay, EEventType eventType)
        {
            eventBuilder.SetStartPrice(startPrice);
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
