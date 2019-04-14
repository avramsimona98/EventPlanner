using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Builder
{
    //Singleton
   public class EventBuildOrganizer
    {
        public IEventBuilder eventBuilder { get; set; }

        private static EventBuildOrganizer _instance;

        private static readonly object padlock = new object();

        private EventBuildOrganizer()
        {

        }

        public static EventBuildOrganizer Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new EventBuildOrganizer();
                    }
                    return _instance;
                }
            }
        }

        /* EventBuildOrganizer(IEventBuilder builder)
        {
            eventBuilder = builder;
        }*/

        public void Construct()
        {
            eventBuilder.SetGuests();
            eventBuilder.SetPackageType();
            eventBuilder.SetLocation();
            eventBuilder.SetEventDay();
            eventBuilder.SetEventType();

        }

     

        public Event GetResult()
        {
            return eventBuilder.GetEvent();
        }
    }
}
