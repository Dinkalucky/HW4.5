using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlDocument();
            document.Load(@"C:\Users\Dina_Nevhod\source\repos\HW4.5\Task5.6\TelephoneBook.xml");
            
            Console.WriteLine(document.InnerXml);
            Console.ReadLine();
        }
    }
}
