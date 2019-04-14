using EventPlanner.Builder;
using EventPlanner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Decorater
{
    public class StandardPackage : IEvent
    {
        public EPackageType PType { get; set; }
        public int Price { get; set; }
        public EEventType EType { get; set; }
        public EEventDay DType { get; set; }
        public ELocation LType { get; set; }
        public int Guests { get; set; }
        public Event eveniment = new Event();
        public static IEventBuilder builder;
        // public EventBuildOrganizer organizer=new EventBuildOrganizer(builder);
       //EventBuildOrganizer eventBuildOrganizer = new EventBuildOrganizer();
        //public EEventType e = eveniment.EventType;
        public StandardPackage(EEventType eventType,EEventDay day, ELocation location, int guests)
        {
            PType = EPackageType.Standard;
            EType = eventType;
            DType = day;
            LType = location;
            //EType = builder.SetEventType();
            Guests = guests;
            //eventBuildOrganizer.Construct(eveniment.Guests, eveniment.PackageType,eveniment.Location, eveniment.EventDay, eveniment.EventType);


            SetPrice();
        }
        public void SetPrice()
        {
             if (DType == EEventDay.WeekTime)
             {
                 switch (EType)
                 {
                     case EEventType.Wedding:
                         {
                             Price = 300;
                             break;
                         }
                     case EEventType.Banquet:
                         {
                             Price = 200;
                             break;
                         }
                     case EEventType.Party:
                         {
                             Price = 100;
                             break;
                         }

                 }
             }
             else
             {
                 switch (EType)
                 {
                     case EEventType.Wedding:
                         {
                             Price = 310;
                             break;
                         }
                     case EEventType.Banquet:
                         {
                             Price = 210;
                             break;
                         }
                     case EEventType.Party:
                         {
                             Price = 110;
                             break;
                         }

                 }
             }
             
           


        }

        public override string ToString()
        {
            return string.Format(
              "    #  " +
             "Package:{0}\n" +
              "    #  " +
             "Event Type:{1}\n" +
              "    #  " +
             "Location:{2}\n" +
              "    #  " +
             "Event Day :{3}\n" +
              "    #  " +
             "Guests :{4}\n" +
              "    #  " +
             "Price/guest:{5}\n",
          PType, EType, LType, DType, Guests, Price);

        }

    }
}

