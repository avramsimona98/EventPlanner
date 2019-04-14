using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Template_Method
{
   public class DocxReportData:ReportData
    {
        public override void ExportData(List<String> data)
        {
            Console.WriteLine("Exporting the data to an Docx file");

            File.WriteAllLines(@"E:\Andra\Facultate\Anul III\Sem2\Design Patterns\Proiect\EventPlanner\EventPlanner\Resources\ResultsDocx.docx", data);
        }
    }
}
