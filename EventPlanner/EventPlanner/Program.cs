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
            eventBuildOrganizer.Construct(100,EPackageType.StandardPlus,ELocation.Belvedere,EEventDay.Weekend,EEventType.Party);
            Event eveniment = eventBuildOrganizer.GetResult();
            Console.WriteLine(eveniment);
           Console.ReadLine();
            //dai cu Enter in consola ca sa iti apara urmatorul
            StandardPackage standard = new StandardPackage(EEventType.Wedding,EEventDay.WeekTime);
            VIPPackage vip = new VIPPackage(standard);
            Console.WriteLine(standard);
            
            //BRIDGE --> tot cu enter
            Console.ReadLine();
            Console.WriteLine("Choose your language: ");
            Console.WriteLine("1.RO 2.ENG");
            string lang = Console.ReadLine();
            switch(lang)
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
