using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }
}
