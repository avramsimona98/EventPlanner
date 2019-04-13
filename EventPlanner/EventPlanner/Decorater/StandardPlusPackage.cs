using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Decorater
{
    public class StandardPlusPackage : EventDecorator
    {

        public StandardPlusPackage(IEvent decoratedEvent) : base(decoratedEvent)
        {
            DecoratedEvent.PType = EPackageType.StandardPlus;
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
                            DecoratedEvent.Price += 50;
                            break;
                        }
                    case EEventType.Banquet:
                        {
                            DecoratedEvent.Price += 40;
                            break;
                        }
                    case EEventType.Party:
                        {
                            DecoratedEvent.Price += 30;
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
                            DecoratedEvent.Price += 50;
                            break;
                        }
                    case EEventType.Banquet:
                        {
                            DecoratedEvent.Price += 40;
                            break;
                        }
                    case EEventType.Party:
                        {
                            DecoratedEvent.Price += 30;
                            break;
                        }
                }


            }
        }
    }


}

