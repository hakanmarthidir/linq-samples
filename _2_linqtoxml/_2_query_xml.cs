using System;
using System.Xml.Linq;
using System.Linq;

namespace _2_linqtoxml
{
    public class QueryXml
    {


        public void GetBooksByElement(string authorName)
        {
            XDocument myDocument = XDocument.Load("books-elements.xml");
            var myBookEnumerable = myDocument.Element("Books").Elements("Book");

            var result = from book in myBookEnumerable
                         where book.Element("Author")?.Value == authorName
                         select book;


            foreach (var item in result)
            {
                Console.WriteLine(item.Element("Name").Value);
            }
        }

        public void GetBooksByAttribute(string authorName)
        {
            XDocument myDocument = XDocument.Load("books-attribute.xml");
            var myBookEnumerable = myDocument.Descendants("Book");

            var result = from book in myBookEnumerable
                         where book.Attribute("Author")?.Value == authorName
                         select book;


            foreach (var item in result)
            {
                Console.WriteLine(item.Attribute("Name").Value);
            }
        }

        public void GetBooksByNamespace(string authorName)
        {
            var myXNamespace = (XNamespace)"http://abcd.com/2021";
            XDocument myDocument = XDocument.Load("books-namespace.xml");
            var myBookEnumerable = myDocument.Descendants(myXNamespace + "Book");

            var result = from book in myBookEnumerable
                         where book.Attribute("Author")?.Value == authorName
                         select book;


            foreach (var item in result)
            {
                Console.WriteLine(item.Attribute("Name").Value);
            }
        }
    }
}
