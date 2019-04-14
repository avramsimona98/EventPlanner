using EventPlanner.Enums;
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
        public EEventDay DType { get=>DecoratedEvent.DType; set=>DecoratedEvent.DType=value; }
        public ELocation LType { get=>DecoratedEvent.LType; set=>DecoratedEvent.LType=value; }
        public EEventType EType{get=>DecoratedEvent.EType;set=>DecoratedEvent.EType=value;}
        public int Price { get=>DecoratedEvent.Price; set=>DecoratedEvent.Price=value; }
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
           "    #  "+
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
