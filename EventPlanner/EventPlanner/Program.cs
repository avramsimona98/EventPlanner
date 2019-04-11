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
        }
    }
}
