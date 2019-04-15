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
            Event proposedEvent = new Event();
            Console.WriteLine("Please choose your event type in order to display our offers:");
            Console.WriteLine("1.Wedding 2.Banquet 3.Party");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    {
                        proposedEvent = ShowOffer(offers, EEventType.Wedding);
                        break;
                    }
                case "2":
                    {
                        proposedEvent = ShowOffer(offers, EEventType.Banquet);
                        break;
                    }
                case "3":
                    {
                        proposedEvent = ShowOffer(offers, EEventType.Party);
                        break;
                    }
            }
            //se salveaza evenimentul in starea respectiva
            Caretaker caretaker = new Caretaker();
            caretaker.eveniment = proposedEvent.Create();

            Console.WriteLine("Would you like to create your own design for the event or you like the current one? (Yes/No)");
            string offer = Console.ReadLine();
            switch (offer)
            {
                case "Yes":
                    {
                        Console.WriteLine("Your custom offer:");
                        proposedEvent = DecoratedVersion();
                        Console.WriteLine("Do you agree with this offer or you like the previous one? (Yes/No)");
                        string choice = Console.ReadLine();
                        if (choice == "No")
                        {
                            proposedEvent.Restore(caretaker.eveniment);
                            Console.WriteLine(proposedEvent);
                        }
                        break;
                    }
                case "No":
                    {
                        Console.WriteLine("Thank you for your time");
                        break;

                    }
            }
            ReportData(proposedEvent);
        }
        public static List<Event> CreateOffers()
        {
            List<Event> offers = new List<Event>();

            EventBuildOrganizer eventBuildOrganizer = EventBuildOrganizer.Instance;

            Event eveniment, clone,clone1;

            eventBuildOrganizer.Construct(300, 100, EPackageType.Standard, ELocation.Belvedere, EEventDay.WeekTime, EEventType.Wedding);//3
            
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
        public static Event ShowOffer(List<Event> offers, EEventType eventType)
        {
            Event offer=new Event();
            Console.WriteLine("Our offers for events are the following:");
            foreach(var eveniment in offers)
            {
                if(eveniment.EventType==eventType)
                {
                    Console.WriteLine(eveniment);
                    offer = eveniment;
                }
            }
            return offer;
        }
        public static Event DecoratedVersion()
        {
            EEventType EType;
            EEventDay DType;
            ELocation LType;
            EPackageType PType;
            //event option
            Console.WriteLine("Every Offer is for 100 guests!");
            Console.WriteLine("Choose your event type:");
            Console.WriteLine("1.Wedding 2.Banquet 3.Party");
            string etype = Console.ReadLine();
            //location option
            Console.WriteLine("Choose your preferred location:");
            Console.WriteLine("1.Belvedere 2.Yaz 3.LuxDivina 4.QEvents");
            string ltype = Console.ReadLine();
            //Weekend/Weektime
            Console.WriteLine("Choose what time of the week you would like (Keep in mind that in weekend there is an extra fee");
            Console.WriteLine("1.Weekend 2.WeekTime");
            string dtype = Console.ReadLine();
            //package option
            Console.WriteLine("Choose what type of event package you would like:");
            Console.WriteLine("1.Standard 2.StandardPlus 3.Premium 4.VIP");
            string ptype = Console.ReadLine();
            //from string to enum
            EType = (EEventType)(Enum.Parse(typeof(EEventType), etype));
            DType = (EEventDay)(Enum.Parse(typeof(EEventDay), dtype));
            LType = (ELocation)(Enum.Parse(typeof(ELocation), ltype));
            PType = (EPackageType)(Enum.Parse(typeof(EPackageType), ptype));
            StandardPackage standard;
            float money = 0;

            switch (PType)
            {
                case EPackageType.Standard:
                    {
                        if ((EType == EEventType.Wedding || EType == EEventType.Banquet || EType == EEventType.Party)
                            && (LType == ELocation.Belvedere || LType == ELocation.Yaz || LType == ELocation.LuxDivina
                            || LType == ELocation.QEvents))
                        {
                            if (DType == EEventDay.Weekend)
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);

                            }
                            else
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);

                            }
                            Console.WriteLine(standard);
                            money = standard.Price;
                        }

                        break;
                    }
                case EPackageType.StandardPlus:
                    {
                        if ((EType == EEventType.Wedding || EType == EEventType.Banquet || EType == EEventType.Party)
                            && (LType == ELocation.Belvedere || LType == ELocation.Yaz || LType == ELocation.LuxDivina
                            || LType == ELocation.QEvents))
                        {
                            if (DType == EEventDay.Weekend)
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);


                            }
                            else
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);

                            }
                            Console.WriteLine(new StandardPlusPackage(standard));
                            money = standard.Price;
                        }

                        break;
                    }
                case EPackageType.Premium:
                    {
                        if ((EType == EEventType.Wedding || EType == EEventType.Banquet || EType == EEventType.Party)
                            && (LType == ELocation.Belvedere || LType == ELocation.Yaz || LType == ELocation.LuxDivina
                            || LType == ELocation.QEvents))
                        {
                            if (DType == EEventDay.Weekend)
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);

                            }
                            else
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);

                            }
                            Console.WriteLine(new PremiumPackage(standard));
                            money = standard.Price;
                        }

                        break;
                    }
                case EPackageType.VIP:
                    {
                        if ((EType == EEventType.Wedding || EType == EEventType.Banquet || EType == EEventType.Party)
                            && (LType == ELocation.Belvedere || LType == ELocation.Yaz || LType == ELocation.LuxDivina
                            || LType == ELocation.QEvents))
                        {
                            if (DType == EEventDay.Weekend)
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);

                            }
                            else
                            {
                                standard = new StandardPackage(EType, DType, LType, 100);

                            }
                            Console.WriteLine(new VIPPackage(standard));
                            money = standard.Price;
                        }

                        break;

                    }
            }
            ShowFinalPrice(money);
            EventBuildOrganizer eventBuildOrganizer = EventBuildOrganizer.Instance;
            Event eveniment;
            eventBuildOrganizer.Construct((int)money, 100, PType, LType, DType, EType);
            eveniment = eventBuildOrganizer.GetResult();
            return eveniment;
        }

        public static void ReportData(Event proposedEvent)
        {
            ReportData data;
            Console.WriteLine("Where do you want to export your final results?");
            Console.WriteLine("1.TextFile 2.DocxFile ");
            string fileOpt = Console.ReadLine();

            List<String> Read = new List<String>();
            switch (fileOpt)
            {
                case "1":
                    {

                        data = new TextReportData();
                        Read.Add(proposedEvent.PackageType.ToString());
                        Read.Add(proposedEvent.EventType.ToString());
                        Read.Add(proposedEvent.Guests.ToString());
                        Read.Add(proposedEvent.Location.ToString());
                        Read.Add(proposedEvent.EventDay.ToString());


                        //Read.Add(money.ToString());
                        data.ExportFormatedData();
                        data.ExportData(Read);
                        break;

                    }
                case "2":
                    {
                        data = new DocxReportData();
                        Read.Add(proposedEvent.PackageType.ToString());
                        Read.Add(proposedEvent.EventType.ToString());
                        Read.Add(proposedEvent.Guests.ToString());
                        Read.Add(proposedEvent.Location.ToString());
                        Read.Add(proposedEvent.EventDay.ToString());
                        //Read.Add(money.ToString());
                        data.ExportData(Read);
                        break;
                    }

            }
        }

        public static void ShowFinalPrice(float money)
        {
            //BRIDGE
            //
            //Price after further talking with the client
            Console.WriteLine("Final price:" + money * 100);
            Console.WriteLine("In what monetary unit would you like your final price to be in : ");
            Console.WriteLine("1.Dollar 2.Euro 3.Lei");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    {
                        Dollar dollar = new Dollar();
                        dollar.MoneyConvert(money * 100);
                        break;
                    }
                case "2":
                    {
                        Dollar dollar = new Dollar();
                        dollar.MoneyConvert(money * 100);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine(money * 100 + " Lei");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("error");
                        break;
                    }
            }
        }
    }
}

