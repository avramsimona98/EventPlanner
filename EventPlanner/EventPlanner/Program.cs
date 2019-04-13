using EventPlanner.Bridge;
using EventPlanner.Builder;
using EventPlanner.Decorater;
using EventPlanner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            EventBuildOrganizer eventBuildOrganizer = new EventBuildOrganizer(new EventBuilder());

            eventBuildOrganizer.Construct(100, EPackageType.StandardPlus, ELocation.Yaz, EEventDay.WeekTime, EEventType.Party);
            Event eveniment = eventBuildOrganizer.GetResult();
            Console.WriteLine(eveniment);
            eventBuildOrganizer.Construct(100, EPackageType.Standard, ELocation.Belvedere, EEventDay.WeekTime, EEventType.Banquet);
            Event eveniment2 = eventBuildOrganizer.GetResult();
            Console.WriteLine(eveniment2);
            /*  Console.ReadLine();
               //dai cu Enter in consola ca sa iti apara urmatorul
               StandardPackage standard = new StandardPackage();

             // VIPPackage vip = new VIPPackage(standard);
               Console.WriteLine(standard);
               */

            //Alege optiunile de event,zi,etc
            EEventType EType;
            EEventDay DType;
            ELocation LType;
            int Guests;
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
            string opt = Console.ReadLine();
         
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
            }
        }
    }
}

