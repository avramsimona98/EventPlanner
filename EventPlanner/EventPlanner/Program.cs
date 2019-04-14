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
            /* EventBuildOrganizer eventBuildOrganizer = EventBuildOrganizer.Instance;

              eventBuildOrganizer.Construct();
              Event eveniment = eventBuildOrganizer.GetResult();
              Console.WriteLine(eveniment);
              eventBuildOrganizer.Construct();
              Event eveniment2 = eventBuildOrganizer.GetResult();
              Console.WriteLine(eveniment2);
              */
            //Singleton
            EventBuildOrganizer organizer = EventBuildOrganizer.Instance;
            Singleton.Client client = new Singleton.Client();
            Event @event = client.GetAnOffer(organizer);
            Console.WriteLine(@event);

            //memento test
            //se creaza un eveniment
            Event eveniment1 = new Event();
            eveniment1.Guests = 100;
            eveniment1.Location = ELocation.Belvedere;
            eveniment1.PackageType = EPackageType.Premium;
            eveniment1.EventType = EEventType.Banquet;
            eveniment1.EventDay = EEventDay.Weekend;

            Console.WriteLine(eveniment1);//se afiseaza evenimentul initial

            Thread.Sleep(2000);
            //se salveaza evenimentul in starea respectiva
            Caretaker caretaker = new Caretaker();
            caretaker.eveniment = eveniment1.Create();
            //se modifica evenimentul initial
            eveniment1.Guests = 150;
            eveniment1.Location = ELocation.LuxDivina;
            eveniment1.PackageType = EPackageType.Premium;
            eveniment1.EventType = EEventType.Banquet;
            eveniment1.EventDay = EEventDay.WeekTime;
            //se afiseaza evenimentul modificat
            Console.WriteLine(eveniment1);
            //se restaureaza evenimentul la starea lui anterioara
            eveniment1.Restore(caretaker.eveniment);
            Console.WriteLine(eveniment1);
            Console.WriteLine("=======================");


            /*  Console.ReadLine();
               StandardPackage standard = new StandardPackage();

             // VIPPackage vip = new VIPPackage(standard);
               Console.WriteLine(standard);
               */

            //Alege optiunile de event,zi,etc
            int Guests = 100;
            Console.WriteLine("Choose your event type:");
            Console.WriteLine("1.Wedding 2.Banquet 3.Party");
            string etype = Console.ReadLine();
            Console.WriteLine("Choose your preferred location:");
            Console.WriteLine("1.Belvedere 2.Yaz 3.LuxDivina 4.QEvents");
            string ltype = Console.ReadLine();
            Console.WriteLine("Choose what time of the week you would like (Keep in mind that in weekend there is an extra fee");
            Console.WriteLine("1.Weekend 2.WeekTime");
            string dtype = Console.ReadLine();
            //optiunea de pachet
            Console.WriteLine("Choose what type of event package you would like:");
            Console.WriteLine("1.Standard 2.StandardPlus 3.Premium 4.VIP");
            string ptype = Console.ReadLine();
            //Export Data with template method
            //Read data as strings ex: Wedding , Yaz etc. not just numbers ...
            //Test Version=> Main will be finished  soon ^_^
            ReportData data;
            Console.WriteLine("Where do you want to export your offer?");
            Console.WriteLine("1.TextFile 2.DocxFile 3.Just diplay it here");
            string fileOpt = Console.ReadLine();
            List<String> Read = new List<String>();
            switch (fileOpt)
            {
                case "1":
                    {

                        data = new TextReportData();
                        Read.Add(ptype);
                        Read.Add(etype);
                        Read.Add(Guests.ToString());
                        Read.Add(ltype);
                        Read.Add(dtype);


                        Read.Add("600");
                        data.ExportFormatedData();
                        data.ExportData(Read);
                        break;

                    }
                case "2":
                    {
                        data = new TextReportData();
                        Read.Add(ptype);
                        Read.Add(etype);
                        Read.Add(Guests.ToString());
                        Read.Add(ltype);
                        Read.Add(dtype);
                        Read.Add("600");
                        data.ExportData(Read);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine(ptype + " " + etype + " " + Guests + " " + ltype + " " + dtype);
                        break;
                    }
            }
            //BRIDGE --> tot cu enter
            //schimba pretul in euro si dolari (se considera lei ca fiind cursul default)
            Console.ReadLine();
            Console.WriteLine("Introdu o suma: ");
            float money = float.Parse(Console.ReadLine());
            Console.WriteLine("1.Dollar 2.Euro 3.Lei");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    {
                        Dollar dollar = new Dollar();
                        dollar.MoneyConvert(money);
                        break;
                    }
                case "2":
                    {
                        Dollar dollar = new Dollar();
                        dollar.MoneyConvert(money);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine(money + " Lei");
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

