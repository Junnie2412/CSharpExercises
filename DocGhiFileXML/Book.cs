
using System.Xml;
using System.Xml.Linq;
class Book
{
    public string Title { get; set; }
    public float Price { get; set; }

    public static void ReadFromFile()
    {
        XmlTextReader reader = new XmlTextReader("books.xml");

        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element:
                    Console.Write("<" + reader.Name);
                    Console.WriteLine(">");
                    break;
                case XmlNodeType.Text:
                    Console.WriteLine(reader.Value);
                    break;
                case XmlNodeType.EndElement:
                    Console.Write("");
                    break;
            }
        }
    }

    public static void WriteToFile()
    {
        Book book = new Book();
        book.Title = "Đắc Nhân Tâm";
        book.Price = 123.5f;

        XDocument xDoc = XDocument.Load("books.xml");

        XElement newBook = new XElement("book",
               new XElement("title", book.Title),
               new XElement("price", book.Price.ToString()));

        xDoc.Element("bookstore").Add(newBook);
        xDoc.Save("books.xml");
    }

    static void Main(string[] args)
    {
        WriteToFile();
        ReadFromFile();
    }
}