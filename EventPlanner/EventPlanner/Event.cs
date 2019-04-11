using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Event
    {
        public int Guests;
        public EPackageType PackageType;
        public ELocation Location;
        public EEventDay EventDay;
        public EEventType EventType;
        public override string ToString()
        {
            return "Eveniment: " + PackageType+ "  "+ Location+" " + EventDay+" " + EventType+" " + Guests;
        }
    }
}
