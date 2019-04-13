using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Decorater
{
    public class PremiumPackage :EventDecorator
    {
        
        public PremiumPackage(IEvent decoratedEvent):base(decoratedEvent)
        {
            DecoratedEvent.PType = EPackageType.Premium;
            SetPrice();
        }
        public override void SetPrice()
        {
            if (DType == EEventDay.WeekTime)
            {
                switch (EType)
                {
                    case EEventType.Wedding:
                        {
                            DecoratedEvent.Price += 150;
                            break;
                        }
                    case EEventType.Banquet:
                        {
                            DecoratedEvent.Price += 100;
                            break;
                        }
                    case EEventType.Party:
                        {
                            DecoratedEvent.Price += 70;
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
                            DecoratedEvent.Price += 150;
                            break;
                        }
                    case EEventType.Banquet:
                        {
                            DecoratedEvent.Price += 100;
                            break;
                        }
                    case EEventType.Party:
                        {
                            DecoratedEvent.Price += 70;
                            break;
                        }



    
                }
            }
        }
    }
    }

