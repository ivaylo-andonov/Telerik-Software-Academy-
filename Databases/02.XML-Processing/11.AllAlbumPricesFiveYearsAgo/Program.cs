namespace _11.AllAlbumPricesFiveYearsAgo
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Albums released 5 years ago and their prices using XPath query:\n");
            GetAlbumPricesFiveYearsAgo();

            Console.WriteLine(new string('-',50));

            Console.WriteLine("Albums released 5 years ago and their prices using LINQ:\n");
            GetAlbumPricesFiveYearsAgoUsingLINQ();
        }

        private static void GetAlbumPricesFiveYearsAgo()
        {
            var fiveYearsAgo = DateTime.Now.Year - 5;
            string queryAlbumsFromFiveYearsAgo = string.Format("/catalogue/album[year>={0}]", fiveYearsAgo);

            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");

            var albumsList = xmlDoc.SelectNodes(queryAlbumsFromFiveYearsAgo);

            foreach (XmlNode node in albumsList)
            {
                var name = node.SelectSingleNode("name").InnerText;
                var year = node.SelectSingleNode("year").InnerText;
                var price = node.SelectSingleNode("price").InnerText;

                Console.WriteLine("Album Name: {0}, Year: {1}, Price: {2}", name, year, price);
            }
        }

        private static void GetAlbumPricesFiveYearsAgoUsingLINQ()
        {
            var fiveYearsAgo = DateTime.Now.Year - 5;
            XElement xmlDoc = XElement.Load("../../catalogue.xml");
            var albums =
                from album in xmlDoc.Elements("album")
                where int.Parse(album.Element("year").Value) >= fiveYearsAgo
                select new
                {
                    Name = album.Element("name").Value,
                    Year = album.Element("year").Value,
                    Price = album.Element("price").Value
                };

            foreach (var album in albums)
            {
                Console.WriteLine("Album Name: {0}, Year: {1}, Price: {2}", album.Name, album.Year, album.Price);
            }
        }
    }
}
