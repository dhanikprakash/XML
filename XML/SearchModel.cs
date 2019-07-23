using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    [XmlRoot("Search", Namespace ="urn:OPUSSearch")]
    public class SearchModel
    {
        [XmlAttribute("SearchScope")]
        public string SearchScope { get; set; }
        [XmlArray("SearchBlock")]
        public List<SearchBlock> searchBlock = new List<SearchBlock>();      
    }


    public class SearchBlock
    {
        [XmlElement("Name")]
        public SearchParams  searchParams{get;set;} 

    }

    public class SearchParams
    {
        [XmlAttribute("Value")]
        public string SearchName { get; set; }
        [XmlAttribute("Operator")]
        public string Operator { get; set; }
    }
}
