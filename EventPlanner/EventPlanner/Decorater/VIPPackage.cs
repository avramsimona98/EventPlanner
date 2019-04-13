using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Decorater
{
    public class VIPPackage:EventDecorator
    {
        
        public VIPPackage(IEvent decoratedEvent):base(decoratedEvent)
        {
            DecoratedEvent.PType = EPackageType.VIP;
            SetPrice();

        }
        public override void SetPrice()
        { if (DType == EEventDay.WeekTime)
            {
                switch (EType)
                {
                    case EEventType.Wedding:
                        {
                            DecoratedEvent.Price += 300;
                            break;
                        }
                    case EEventType.Banquet:
                        {
                            DecoratedEvent.Price += 160;
                            break;
                        }
                    case EEventType.Party:
                        {
                            DecoratedEvent.Price += 130;
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
                            DecoratedEvent.Price += 300;
                            break;
                        }
                    case EEventType.Banquet:
                        {
                            DecoratedEvent.Price += 160;
                            break;
                        }
                    case EEventType.Party:
                        {
                            DecoratedEvent.Price += 130;
                            break;
                        }



                }

            }
        }
    }
    }

