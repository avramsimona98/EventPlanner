using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class StandardPackage : IEvent
    {
        public EPackageType PType { get; set; }
        public int Price { get; set; }
        public EEventType EType { get; set; }
        public EEventDay DType { get; set; }
        public ELocation LType { get; set; }
        public int guests { get; set; }
        public static IEventBuilder builder { get; set; }
        // public EventBuildOrganizer organizer=new EventBuildOrganizer(builder);

        public StandardPackage(EEventType type,EEventDay day)
        {
            PType = EPackageType.Standard;
            EType = type;
            DType = day;
            // organizer.Construct(guests, PType, LType, DType, EType);


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
                "Package:{0}\n" +
                "Event Type:{1}\n" +
                "Location:{2}\n" +
                "Price:{3}\n",
                PType, EType, LType, Price);
        }

    }
}

