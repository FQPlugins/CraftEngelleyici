using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CraftEngelleyici
{
    public class craftItem
    {
        [XmlArrayItem("SItem")]
        public List<ushort> item = new List<ushort>();
        [XmlAttribute("Permission")]
        public string Permission;
    }
}
