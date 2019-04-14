using EventPlanner.Enums;
using EventPlanner.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Builder
{
    public class Event
    {
        public int StartPrice;
        public int Guests;
        public EPackageType PackageType;
        public ELocation Location;
        public EEventDay EventDay;
        public EEventType EventType;

        public override string ToString()
        {
            return "Eveniment: " + PackageType+ "  "+ Location+" " + EventDay+" " + EventType+" " + Guests;
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
