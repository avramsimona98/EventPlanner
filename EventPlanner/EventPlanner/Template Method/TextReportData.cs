using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPlanner.Decorater;
using System.Resources;
namespace EventPlanner.Template_Method
{
    public class TextReportData : ReportData
    {
        public override void ExportData(List<String>data)
        {
           // string fullpath = Path.GetFullPath(@"ResultText.Txt");
            Console.WriteLine("Exporting the data to a Text file");
            //Console.WriteLine(fullpath);

            File.WriteAllLines(@"E:\Andra\Facultate\Anul III\Sem2\Design Patterns\Proiect\EventPlanner\EventPlanner\Resources\ResultText.txt", data);

        }
    }
}
