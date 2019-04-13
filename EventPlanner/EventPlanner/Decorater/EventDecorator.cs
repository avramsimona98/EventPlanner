using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Decorater
{
    public abstract class EventDecorator : IEvent
    {
        public EPackageType PType { get => DecoratedEvent.PType; set => DecoratedEvent.PType = value; }
        public EEventDay DType { get; set; }
        public ELocation LType { get; set; }
        public EEventType EType{get;set;}
        public int Price { get; set; }
        public IEvent DecoratedEvent { get; set; }
       // public Event eveniment=new Event();
        public int Guests { get; set; }
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
          "Event Day :{3}\n" +
          "Guests :{4}\n" +
          "Price/guest:{5}\n",
       PType, EType, LType, DType, Guests, Price);
        }

    }
}
