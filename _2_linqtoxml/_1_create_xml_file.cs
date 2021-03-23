using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace _2_linqtoxml
{
    public class CreateXmlFile
    {

        private List<Book> bookList = new List<Book>() {

            new Book(){ Name="Fight Club", Author="Chuck Palahniuk", Price=10 },
            new Book(){ Name="Julius Caesar", Author="William Shakespeare", Price=23 },
            new Book(){ Name="Dubliners", Author="James Joyce", Price=45 }
        };

        public void ElementOrientedApproach()
        {
            //Element Oriented Approach

            //<Books>
            //      <Book>
            //          <Name>
            //          <Author>
            //      <Book>
            //<Books>

            var document = new XDocument();
            //Books
            var books = new XElement("Books");

            foreach (var item in bookList)
            {
                var book = new XElement("Book");

                var name = new XElement("Name", item.Name);
                var author = new XElement("Author", item.Author);
                var price = new XElement("Price", item.Price);

                book.Add(name);
                book.Add(author);
                book.Add(price);

                books.Add(book);
            }

            document.Add(books);
            document.Save("books-elements.xml");
            Console.WriteLine("books xml created...");

        }

        public void AttributeOrientedApproach()
        {
            var document = new XDocument();
            var books = new XElement("Books");

            foreach (var item in bookList)
            {
                var name = new XAttribute("Name", item.Name);
                var author = new XAttribute("Author", item.Author);
                var price = new XAttribute("Price", item.Price);

                var book = new XElement("Book", name, author, price);

                //or
                //var book = new XElement("Book",
                //                        new XAttribute("Name", item.Name),
                //                        new XAttribute("Author", item.Author)
                //                        new XAttribute("Price", item.Price)
                //    );

                books.Add(book);
            }

            document.Add(books);
            document.Save("books-attribute.xml");
            Console.WriteLine("books xml created...");

        }

        public void AttributeOrientedApproachWithLinq()
        {
            var document = new XDocument();
            var books = new XElement("Books",
                                            from b in this.bookList
                                            select new XElement("Book",
                                            new XAttribute("Name", b.Name),
                                            new XAttribute("Author", b.Author),
                                            new XAttribute("Price", b.Price))
                );

            document.Add(books);
            document.Save("books-attribute-linq.xml");
            Console.WriteLine("books xml created...");
        }

        public void XmlNamespaceSample()
        {
            var myXNamespace = (XNamespace)"http://abcd.com/2021";
            var document = new XDocument();
            var books = new XElement(myXNamespace + "Books",
                                            from b in this.bookList
                                            select new XElement(myXNamespace + "Book",
                                            new XAttribute("Name", b.Name),
                                            new XAttribute("Author", b.Author),
                                            new XAttribute("Price", b.Price))
                );

            document.Add(books);
            document.Save("books-namespace.xml");
            Console.WriteLine("books xml created...");
        }

    }
}
