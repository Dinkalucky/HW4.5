using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Task5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlDocument();
            document.Load(@"C:\Users\Dina_Nevhod\source\repos\HW4.5\Task5.6\TelephoneBook.xml");

            XPathNavigator navigator = document.CreateNavigator();
            
            XPathNodeIterator iterator = navigator.Select("MyContacts/Contact/TelephoneNumber");

            foreach (var item in iterator)
                Console.WriteLine(item);


            Console.ReadKey();
        }
    }
}
