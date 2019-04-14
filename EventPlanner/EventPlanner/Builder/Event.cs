using EventPlanner.Enums;
using EventPlanner.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Builder
{
    public class Event:IEventPrototype
    {
        public int StartPrice;
        public int Guests;
        public EPackageType PackageType;
        public ELocation Location;
        public EEventDay EventDay;
        public EEventType EventType;
        public bool IsClone { get; set; }
        public Event Clone()
        {
            Event eveniment = (Event)MemberwiseClone();
            eveniment.IsClone = true;
            return eveniment;
        }
        public override string ToString()
        {
            return string.Format(
              "The prices will change depending of your choices.\n" +
              "\n" +
             "Package:{0}\n" +
             "      *        " +
             "Event Type:{1}\n" +
              "      *        " +
             "Location: {2} \n" +
              "      *        " +
             "Event Day : Weekend/Weektime\n" +
              "      *        " +
             "Start Price  :{3}\n" +

             "\n" +
             "Every Offer is for a number of 100 guests.\n" +
             "..............................................\n",

          PackageType, EventType, Location, StartPrice);
        }

        public EventMemento Create()
        {
            return new EventMemento(Guests, PackageType, Location, EventDay, EventType);
        }
        public void Restore(EventMemento eveniment)
        {
            this.Guests = eveniment.Guests;
            this.PackageType = eveniment.PackageType;
            this.Location = eveniment.Location;
            this.EventDay = eveniment.EventDay;
            this.EventType = eveniment.EventType;
        }

    }
}
