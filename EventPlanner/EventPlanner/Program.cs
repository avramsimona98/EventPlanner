using EventPlanner.Bridge;
using EventPlanner.Builder;
using EventPlanner.Decorater;
using EventPlanner.Enum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventPlanner
{

    public class Program
    {
       /* public void Offers()
        {
            EventBuildOrganizer eventBuildOrganizer = new EventBuildOrganizer(new EventBuilder());
            Console.WriteLine("Our offers for events are the following:");
            Console.WriteLine("Please choose your event type in order to display our offers:");
            Console.WriteLine("1.Wedding 2.Banquet 3.Party");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    {
                        foreach (var i in Enum.GetValues(typeof(ELocation)))
                        {
                            eventBuildOrganizer.Construct(300, EPackageType.Standard, i.ToString(), EEventType.Wedding);
                            Event eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(350, EPackageType.StandardPlus, i.ToString(), EEventType.Wedding);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(450, EPackageType.Premium, i.ToString(), EEventType.Wedding);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(600, EPackageType.VIP, i.ToString(), EEventType.Wedding);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                        }

                        break;
                    }
                case "2":
                    {
                        foreach (var i in Enum.GetValues(typeof(ELocation)))
                        {
                            eventBuildOrganizer.Construct(200, EPackageType.Standard, i.ToString(), EEventType.Banquet);
                            Event eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(240, EPackageType.StandardPlus, i.ToString(), EEventType.Banquet);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(300, EPackageType.Premium, i.ToString(), EEventType.Banquet);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(360, EPackageType.VIP, i.ToString(), EEventType.Banquet);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                        }
                        break;
                    }
                case "3":
                    {
                        foreach (var i in Enum.GetValues(typeof(ELocation)))
                        {
                            eventBuildOrganizer.Construct(100, EPackageType.Standard, i.ToString(), EEventType.Party);
                            Event eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(130, EPackageType.StandardPlus, i.ToString(), EEventType.Party);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(170, EPackageType.Premium, i.ToString(), EEventType.Party);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                            eventBuildOrganizer.Construct(230, EPackageType.VIP, i.ToString(), EEventType.Party);
                            eveniment = eventBuildOrganizer.GetResult();
                            Console.WriteLine(eveniment);
                        }
                        break;
                    }
            }

        }*/
        /*public void ClientOffer()
        {
            EEventType EType;
            EEventDay DType;
            ELocation LType;
            EPackageType PType;
            int Guests = 100;

            Console.WriteLine("Choose your event type:");
            Console.WriteLine("1.Wedding 2.Banquet 3.Party");
            string etype = Console.ReadLine();
            // Console.ReadLine();
            Console.WriteLine("Choose your prefered location:");
            Console.WriteLine("1.Belvedere 2.Yaz 3.LuxDivina 4.QEvents");
            string ltype = Console.ReadLine();
            Console.WriteLine("Choose what time of the week you would like (Keep in mind that in weekend there is an extra fee");
            Console.WriteLine("1.Weekend 2.WeekTime");
            string dtype = Console.ReadLine();
            //optiunea de pachet
            Console.WriteLine("Choose what type of event package you would like:");
            Console.WriteLine("1.Standard 2.StandardPlus 3.Premium 4.VIP");
            string ptype = Console.ReadLine();
            EType = (EEventType)(Enum.Parse(typeof(EEventType), etype));
            DType = (EEventDay)(Enum.Parse(typeof(EEventDay), dtype));
            LType = (ELocation)(Enum.Parse(typeof(ELocation), ltype));
            PType = (EPackageType)(Enum.Parse(typeof(EPackageType), ptype));
            StandardPackage standard;
            StandardPlusPackage plus;
           // PremiumPackage premium;
            VIPPackage vip;
            if (PType == EPackageType.Standard)
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
                }


            }
            if (PType == EPackageType.StandardPlus)
            {
                if ((EType == EEventType.Wedding || EType == EEventType.Banquet || EType == EEventType.Party)
                    && (LType == ELocation.Belvedere || LType == ELocation.Yaz || LType == ELocation.LuxDivina
                    || LType == ELocation.QEvents))
                {
                    if (DType == EEventDay.Weekend)
                    {
                        standard = new StandardPackage(EType, DType, LType, 100);
                        plus = new StandardPlusPackage(standard);
                        // Console.WriteLine(plus);
                    }
                    else
                    {
                        standard = new StandardPackage(EType, DType, LType, 100);
                        plus = new StandardPlusPackage(standard);

                    }
                    Console.WriteLine(plus);
                }


            }
            if (PType == EPackageType.Premium)
            {
                if ((EType == EEventType.Wedding || EType == EEventType.Banquet || EType == EEventType.Party)
                    && (LType == ELocation.Belvedere || LType == ELocation.Yaz || LType == ELocation.LuxDivina
                    || LType == ELocation.QEvents))
                {
                    if (DType == EEventDay.Weekend)
                    {
                        standard = new StandardPackage(EType, DType, LType, 100);
                       PremiumPackage premium = new PremiumPackage(standard);
                        Console.WriteLine(premium);
                    }
                    else
                    {
                        standard = new StandardPackage(EType, DType, LType, 100);
                       PremiumPackage premium = new PremiumPackage(standard);
                        Console.WriteLine(premium);
                    }
                  
                }


            }
            if (PType == EPackageType.VIP)
            {
                if ((EType == EEventType.Wedding || EType == EEventType.Banquet || EType == EEventType.Party)
                    && (LType == ELocation.Belvedere || LType == ELocation.Yaz || LType == ELocation.LuxDivina
                    || LType == ELocation.QEvents))
                {
                    if (DType == EEventDay.Weekend)
                    {
                        standard = new StandardPackage(EType, DType, LType, 100);
                        vip = new VIPPackage(standard);
                        Console.WriteLine(vip);
                    }
                    else
                    {
                        standard = new StandardPackage(EType, DType, LType, 100);
                        vip = new VIPPackage(standard);
                        Console.WriteLine(vip);
                    }
                    Console.WriteLine(vip);
                }

            }





            /*standard = new StandardPackage(EEventType.Party, EEventDay.Weekend,ELocation.Yaz , 100);
            VIPPackage vip = new VIPPackage(standard);
            Console.WriteLine(vip);
        }*/
        
    
        static void Main(string[] args)
        {
          /*  EventBuildOrganizer eventBuildOrganizer = new EventBuildOrganizer(new EventBuilder());

            eventBuildOrganizer.Construct(100, EPackageType.StandardPlus, (ELocation.Yaz).ToString(), EEventType.Party);
            Event eveniment = eventBuildOrganizer.GetResult();
            Console.WriteLine(eveniment);
            eventBuildOrganizer.Construct(100, EPackageType.Standard, ELocation.Belvedere.ToString(), EEventType.Banquet);
            Event eveniment2 = eventBuildOrganizer.GetResult();
            Console.WriteLine(eveniment2);

            Program pro = new Program();
            // pro.Offers();
            //EventBuildOrganizer eventBuildOrganizer = new EventBuildOrganizer(new EventBuilder());

            //eventBuildOrganizer.Construct(300, EPackageType.StandardPlus, ELocation.Yaz, EEventDay.WeekTime, EEventType.Party);
            // Event eveniment = eventBuildOrganizer.GetResult();
            // Console.WriteLine(eveniment);
            // eventBuildOrganizer.Construct(100, EPackageType.Standard, ELocation.Belvedere, EEventDay.WeekTime, EEventType.Banquet);
            // Event eveniment2 = eventBuildOrganizer.GetResult();
            // Console.WriteLine(eveniment2);
            Console.ReadLine();
            // dai cu Enter in consola ca sa iti apara urmatorul
           // pro.ClientOffer();
            //memento test
            //se creaza un eveniment
            //StandardPackage standard = new StandardPackage(EEventType.Party,EEventDay.WeekTime,ELocation.Yaz,100);
            //VIPPackage vip = new VIPPackage(standard);
            //Console.WriteLine(standard);

            Event eveniment1 = new Event();
            eveniment1.Guests = 100;
            eveniment1.Location = ELocation.Belvedere.ToString();
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
            eveniment1.Location = ELocation.LuxDivina.ToString();
            eveniment1.PackageType = EPackageType.Premium;
            eveniment1.EventType = EEventType.Banquet;
            eveniment1.EventDay = EEventDay.WeekTime;
            //se afiseaza evenimentul modificat
            Console.WriteLine(eveniment1);
            //se restaureaza evenimentul la starea lui anterioara
            eveniment1.Restore(caretaker.eveniment);
            Console.WriteLine(eveniment1);
            Console.WriteLine("=======================");

            //Alege optiunile de event,zi,etc
            EEventType EType;
            EEventDay DType;
            ELocation LType;
            int Guests=100;
            StandardPackage standard;
            Console.WriteLine("Choose your event type:");
            Console.WriteLine("1.Wedding 2.Banquest 3.Party");
            string etype = Console.ReadLine();
            // Console.ReadLine();
            Console.WriteLine("Choose your prefered location:");
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
            Console.WriteLine("1.TextFile 2.DocxFile");
            string fileOpt = Console.ReadLine();
            List<String> Read = new List<String>();
            switch(fileOpt)
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
            }
            //BRIDGE --> tot cu enter
            Console.ReadLine();
            Console.WriteLine("Choose your language: ");
            Console.WriteLine("1.RO 2.ENG");
            string lang = Console.ReadLine();
            switch (lang)
            {
                case "1":
                    {
                        Romanian ro = new Romanian();
                        ro.LanguageTranslator();
                        Console.WriteLine("introdu bani:");
                        float money = float.Parse(Console.ReadLine());
                        Console.WriteLine("1.euro 2.dolari 3.lei");
                        string val = Console.ReadLine();
                        switch (val)
                        {
                            case "1":
                                {
                                    ro.ConvertToEuro(money);
                                    break;
                                }
                            case "2":
                                {
                                    ro.ConvertToDollar(money);
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine(money);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("error");
                                    break;
                                }

                        }
                        break;
                    }
                case "2":
                    {
                        English eng = new English();
                        eng.LanguageTranslator();
                        Console.WriteLine("insert money:");
                        float money = float.Parse(Console.ReadLine());
                        Console.WriteLine("1.euro 2.dollars 3.lei");
                        string val = Console.ReadLine();
                        switch (val)
                        {
                            case "1":
                                {
                                    eng.ConvertToEuro(money);
                                    break;
                                }
                            case "2":
                                {
                                    eng.ConvertToDollar(money);
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine(money);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("error");
                                    break;
                                }

                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("error");
                        break;
                    }
            }*/
        }
    }
}

