namespace _10.TraverseDirUsingXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            var favorites = new XElement("Favorites", new XAttribute("path", dir));

            favorites.Add(TraveringRecursivelyUsingXDocument(dir));
            favorites.Save("../../my-favorites.xml");

            Console.WriteLine("The result is saved as my-favorites.xml in current folder.");
        }

        private static XElement TraveringRecursivelyUsingXDocument(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(TraveringRecursivelyUsingXDocument(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file", new XAttribute("name", Path.GetFileName(file))));
            }

            return element;
        }

    }
}
