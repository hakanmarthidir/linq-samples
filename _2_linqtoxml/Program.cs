using System;

namespace _2_linqtoxml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LINQtoXML!");

            //CREATE XML
            CreateXmlFile createXmlFile = new CreateXmlFile();
            //createXmlFile.ElementOrientedApproach();
            //createXmlFile.AttributeOrientedApproach();
            //createXmlFile.AttributeOrientedApproachWithLinq();
            //createXmlFile.XmlNamespaceSample();

            //QUERY XML
            QueryXml queryXml = new QueryXml();

            queryXml.GetBooksByElement("William Shakespeare");
            queryXml.GetBooksByAttribute("Chuck Palahniuk");
            queryXml.GetBooksByNamespace("James Joyce");
        }
    }
}
