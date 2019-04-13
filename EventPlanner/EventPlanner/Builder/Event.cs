using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace EventPlanner.Builder
{
    public class Event
    {
        public int Guests;
        public EPackageType PackageType;
        public string Location;
        public EEventDay EventDay;
        public EEventType EventType;
        public int StartPrice;
       
       
        
        public override string ToString()
        {
            //return "Eveniment: " + PackageType+ "  "+ Location+" " + EventDay+" " + EventType+" " + Guests;
            return string.Format(
              "The prices will change depending of your choices.\n"+
              "\n"+
             "Package:{0}\n" +
             "      *        "+
             "Event Type:{1}\n" +
              "      *        " +
             "Location: {2} \n" +
              "      *        " +
             "Event Day : Weekend/Weektime\n" +
              "      *        " +
             "Start Price  :{3}\n" +
             
             "\n"+
             "Every Offer is for a number of 100 guests.\n"+
             "..............................................\n",

          PackageType, EventType,Location, StartPrice);
          
        }
       
    }
}
