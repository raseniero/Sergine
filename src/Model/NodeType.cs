using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sergine.Model;

namespace Sergine
{
    public class NodeType
    {
        public String Text;
        
        public ElementData Element;
        
        public NodeType()
        {
        }
        
        public NodeType(String text, ElementData element)
        {
            this.Element = element;
            this.Text = text;
        }
    }
}
