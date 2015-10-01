namespace _09.TraverseDirectoryAndWriteXML
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../favorites-dir.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 4;

                string favoritesPath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

                writer.WriteStartDocument();
                writer.WriteStartElement("Favorites");
                writer.WriteAttributeString("dir", favoritesPath);
                TraversingRecursively(favoritesPath, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("The result is saved as favorites-dir.xml in current folder");
        }

        static void TraversingRecursively(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                TraversingRecursively(directory, writer);
                writer.WriteEndElement();
            }
            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileName(file));
                writer.WriteEndElement();
            }
        }
    }
}

