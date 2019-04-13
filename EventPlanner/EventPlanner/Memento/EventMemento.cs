using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPlanner.Builder;
using EventPlanner.Enums;

namespace EventPlanner.Memento
{
    public class EventMemento
    {
        public int Guests;
        public EPackageType PackageType { get; private set; }
        //public ELocation Location { get; private set; }
        public string Location;
        public EEventDay EventDay { get; private set; }
        public EEventType EventType { get; private set; }

        public EventMemento(int guests, EPackageType packageType,string location, EEventDay eventDay, EEventType eventType)
        {

            this.Guests = guests;
            this.PackageType = packageType;
            this.Location = location;
            this.EventDay = eventDay;
            this.EventType = eventType;
        }

    }
}