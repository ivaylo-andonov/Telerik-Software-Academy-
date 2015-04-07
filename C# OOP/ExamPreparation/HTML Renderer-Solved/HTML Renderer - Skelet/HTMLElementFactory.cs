using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    
    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            throw new NotImplementedException();
        }

        public IElement CreateElement(string name, string content)
        {
            throw new NotImplementedException();
        }

        public ITable CreateTable(int rows, int cols)
        {
            throw new NotImplementedException();
        }
    }
}
