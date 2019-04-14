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
       public IEventBuilder eventBuilder;
        public EventBuildOrganizer(IEventBuilder builder)
        {
            eventBuilder = builder;
        }
        public void Construct(int startPrice, EPackageType packageType, ELocation location,EEventType eventType)
        {
            eventBuilder.SetStartPrice(startPrice);
            eventBuilder.SetPackageType(packageType);
            eventBuilder.SetLocation(location);
           // eventBuilder.SetEventDay(eventDay);
            eventBuilder.SetEventType(eventType);

        }

     

        public Event GetResult()
        {
            return eventBuilder.GetEvent();
        }
    }
}
