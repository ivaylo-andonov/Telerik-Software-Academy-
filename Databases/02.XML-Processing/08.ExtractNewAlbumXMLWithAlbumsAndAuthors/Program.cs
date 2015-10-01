namespace _08.ExtractNewAlbumXMLWithAlbumsAndAuthors
{
    using System;
    using System.Text;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            var albumsLocation = "../../xml/album.xml";
            var catalogueLocation = "../../xml/catalogue.xml";

            using (var reader = new XmlTextReader(catalogueLocation))
            {
                using (var writer = new XmlTextWriter(albumsLocation, Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteStartElement("name");
                            writer.WriteString(reader.ReadElementString());
                            writer.WriteEndElement();
                        }
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "artist")
                        {
                            writer.WriteStartElement("artist");
                            writer.WriteString(reader.ReadElementString());
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            Console.WriteLine("Task 08");
            Console.WriteLine("Albums and their authors -> new album.xml generated in main directory\n");
        }
    }
}
