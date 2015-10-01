namespace XML_Parsers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public class Program
    {
        static void Main()
        {
            var fileLocation = "../../xml/catalogue.xml";

            Console.WriteLine("--- DOM Processing Homework ---");

            Console.WriteLine("\nTask 01 \nYou can see catalogue.xml in current dir ./xml/catalogue.xml");
            Console.WriteLine(new string('-', 50));

            GetAllArtistAndNumberOfTheirAlbumsUsingDomParserAndHashTable(fileLocation);

            GetAllArtistAndNumberOfTheirAlbumsUsingXPathAndHashTable(fileLocation);

            DeleteAllAlbumsWithPriceGreaterThan20UsingDOMParser(fileLocation);

            ExtractAllSongsTitleWithXmlReader(fileLocation);

            ExtractAllSongTitlesUsingXDocumentLINQ(fileLocation);

        }

        //Task 2
        private static void GetAllArtistAndNumberOfTheirAlbumsUsingDomParserAndHashTable(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);
            var root = doc.DocumentElement;

            var artistsList = new Hashtable();
            int indexer = 1;

            foreach (XmlNode node in root.ChildNodes)
            {
                var artist = node["artist"].InnerText;
                if (artistsList.ContainsKey(artist))
                {
                    indexer += 1;
                    artistsList[artist] = indexer;
                }
                else
                {
                    artistsList.Add(artist, 1);
                }


            }
            Console.WriteLine("Task 02\nUsing DOM Parser");
            Console.WriteLine("All different artists and number of their albums: \n");
            foreach (DictionaryEntry entry in artistsList)
            {
                Console.WriteLine("Artist: {0} has {1} albums", entry.Key, entry.Value);
            }
            Console.WriteLine(new string('-', 50));
        }

        //Task3
        private static void GetAllArtistAndNumberOfTheirAlbumsUsingXPathAndHashTable(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);

            var queryPath = "/catalogue/album/artist";

            XmlNodeList artists = doc.SelectNodes(queryPath);

            var artistsList = new Hashtable();
            int indexer = 1;

            foreach (XmlNode node in artists)
            {
                var artist = node.InnerText;
                if (artistsList.ContainsKey(artist))
                {
                    indexer += 1;
                    artistsList[artist] = indexer;
                }
                else
                {
                    artistsList.Add(artist, 1);
                }
            }

            Console.WriteLine("Task 03\nUsing XPath");
            Console.WriteLine("All different artists and number of their albums: \n");
            foreach (DictionaryEntry entry in artistsList)
            {
                Console.WriteLine("Artist: {0} has {1} albums", entry.Key, entry.Value);
            }
            Console.WriteLine(new string('-', 50));
        }

        //Task 4
        private static void DeleteAllAlbumsWithPriceGreaterThan20UsingDOMParser(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);
            var root = doc.DocumentElement;

            var nodesToRemove = new List<XmlNode>();

            foreach (XmlNode node in root.ChildNodes)
            {
                var price = Decimal.Parse(node["price"].InnerText);

                if (price > 20)
                {
                    nodesToRemove.Add(node);
                }
            }

            foreach (XmlNode node in nodesToRemove)
            {
                root.RemoveChild(node);
            }

            Console.WriteLine("Task 04.\nNew file catalogueWithCheaperAlbums.xml is created in folder xml/.\n");
            doc.Save("../../xml/" + "catalogueWithCheaperAlbums.xml");
            Console.WriteLine(new string('-', 50));
        }

        //Task 5
        private static void ExtractAllSongsTitleWithXmlReader(string fileLocation)
        {
            Console.WriteLine("Task 05.\nAll song titles from the catalogue.xml using XmlReader:\n");
            using (XmlReader reader = XmlReader.Create(fileLocation))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
            Console.WriteLine(new string('-', 50));
        }

        //Task 6
        private static void ExtractAllSongTitlesUsingXDocumentLINQ(string fileLocation)
        {
            Console.WriteLine("Task 06\nAll song titles from the catalogue.xml using XDocument: \n");

            var doc = XDocument.Load(fileLocation);

            var titles = from title in doc.Descendants("title") select title.Value;
            // removes duplicate entries
            
            Console.WriteLine(string.Join("\r\n", titles));
            Console.WriteLine(new string('-', 50));
        }

    }
}
