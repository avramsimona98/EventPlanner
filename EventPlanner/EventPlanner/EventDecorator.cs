using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public abstract class EventDecorator : IEvent
    {
        public EPackageType PType { get => DecoratedEvent.PType; set => DecoratedEvent.PType = value; }
        public EEventDay DType { get; set; }
        public ELocation LType { get; set; }
        public EEventType EType{get;set;}
        public int Price { get; set; }
        public IEvent DecoratedEvent { get; set; }
        public EventDecorator(IEvent decoratedEvent)
        {
            DecoratedEvent = decoratedEvent;
            
        }
        public abstract void SetPrice();
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
