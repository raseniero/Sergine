using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sergine.Model
{
    public class ElementData
    {
        public String TagName;
        
        public Dictionary<String, String> Attribute;
        public ElementData()
        {
        }
        
        public ElementData(String tagName, Dictionary<String, String> attribute)
        {
            this.TagName = tagName;
            this.Attribute = attribute;
        }
    }
}
