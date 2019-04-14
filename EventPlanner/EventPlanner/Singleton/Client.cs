using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Singleton
{
    public class Client
    { 

        public Builder.Event GetAnOffer(Builder.EventBuildOrganizer organizer)
        {
            organizer.eventBuilder = new Builder.EventBuilder();
            organizer.Construct();
            return organizer.GetResult();
        }
    }
}
