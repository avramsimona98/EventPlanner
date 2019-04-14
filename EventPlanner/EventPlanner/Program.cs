using EventPlanner.Bridge;
using EventPlanner.Builder;
using EventPlanner.Memento;
using EventPlanner.Decorater;
using EventPlanner.Enums;
using EventPlanner.Template_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Event> offers = CreateOffers();
            Console.WriteLine("Please choose your event type in order to display our offers:");
            Console.WriteLine("1.Wedding 2.Banquet 3.Party");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    {
                        ShowOffers(offers, EEventType.Wedding);
                        break;
                    }
                case "2":
                    {
                        ShowOffers(offers, EEventType.Banquet);
                        break;
                    }
                case "3":
                    {
                        ShowOffers(offers, EEventType.Party);
                        break;
                    }
            }
        }
        public static List<Event> CreateOffers()
        {
            List<Event> offers = new List<Event>();

            EventBuildOrganizer eventBuildOrganizer = new EventBuildOrganizer(new EventBuilder());
            Event eveniment, clone,clone1;

            eventBuildOrganizer.Construct(300, 100, EPackageType.Standard, ELocation.Belvedere, EEventDay.WeekTime, EEventType.Wedding);
            eveniment = eventBuildOrganizer.GetResult();
            offers.Add(eveniment);
            clone = eveniment.Clone();
            clone.StartPrice = 200;
            clone.EventType = EEventType.Banquet;
            offers.Add(clone);
            clone1 = eveniment.Clone();
            clone1.StartPrice = 100;
            clone1.EventType = EEventType.Party;
            offers.Add(clone1);

            return offers;
        }
        public static void ShowOffers(List<Event> offers, EEventType eventType)
        {
            Console.WriteLine(offers.Count());
            Console.WriteLine("Our offers for events are the following:");
            foreach(var eveniment in offers)
            {
                if(eveniment.EventType==eventType)
                {
                    Console.WriteLine(eveniment);
                }
            }
        }
    }
}

