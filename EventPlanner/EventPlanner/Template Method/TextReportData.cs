using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPlanner.Decorater;

namespace EventPlanner.Template_Method
{
    public class TextReportData : ReportData
    {
        public override void ExportData(List<String>data)
        {
            Console.WriteLine("Exporting the data to a Text file");

            File.WriteAllLines(@"E:\Andra\Facultate\Anul III\Sem2\Design Patterns\Proiect\EventPlanner\EventPlanner\ResultText.txt",data );
        }
    }
}
