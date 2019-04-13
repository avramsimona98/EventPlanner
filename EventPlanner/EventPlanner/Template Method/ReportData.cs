using EventPlanner.Decorater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Template_Method
{
   public abstract class ReportData
    {
        public StandardPackage standard;
        public List<String> data=new List<string>();
        public void ReadData()
        {
           
            Console.WriteLine("Your Offer has been registered");

        }
        public void FormatData()
        {
            
            Console.WriteLine("Formating the data ...");
           

        }
        public abstract void ExportData(List<String> data);
        public void ExportFormatedData()
        {
            this.ReadData();
            this.FormatData();
            this.ExportData(data);
        }
    }
}
