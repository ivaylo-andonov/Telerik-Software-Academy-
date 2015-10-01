namespace _13_16.TransformingXmlIntoHTMLAndSchemas
{
    using System;
    using System.Xml.Xsl;

    class Program
    {
        static void Main()
        {
            var xsltTransformer = new XslCompiledTransform();
            xsltTransformer.Load("../../xml-files/style.xslt");
            xsltTransformer.Transform("../../xml-files/catalogue.xml", "../../xml-files/catalogue.html");

            Console.WriteLine("New catalogue.html file is created in ./xml-files folder");
        }
    }
}
