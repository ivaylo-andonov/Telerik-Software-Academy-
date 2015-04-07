using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HtmlElement : IElement
    {
        private ICollection<IElement> childElements;

        public HtmlElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public HtmlElement(string name, string textContent)
            : this(name)
        {
            this.TextContent = textContent;
        }

        public string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public virtual IEnumerable<IElement> ChildElements
        {
            get { return this.childElements; }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {
                for (int i = 0; i < this.TextContent.Length; i++)
                {
                    char symbol = this.TextContent[i];
                    switch (symbol)
                    {
                        case '<':
                            output.Append("&lt;");
                            break;
                        case '>':
                            output.Append("&gt;");
                            break;
                        case '&':
                            output.Append("&amp;");
                            break;
                        default:
                            output.Append(symbol);
                            break;
                    }
                }
            }

            foreach (var childElement in this.ChildElements)
            {
                output.Append(childElement.ToString());
            }

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }
    }
}
