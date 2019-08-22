using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class AssetSearch
    {

        public string SearchAsset(string assetName, string searchScope)
        {
            //Xml-improvements #1
            //Xml-improvements #2
            var search = new SearchModel();
            var searchBlock = new SearchBlock();
            var searchParams = new SearchParams();

            searchParams.SearchName = assetName;
            searchParams.Operator = "Containts";
            searchBlock.searchParams = searchParams;
            search.SearchScope = searchScope;
            search.searchBlock.Add(searchBlock);

            var sResult = Serializer.Serialize<SearchModel>(search);

            var j = 1;
            var k = 2;
            var x = 1;
            var z = 0;
            // var model = new SearchModelV2(assetName, searchScope);
            //var xmlNode = new XElement("Search",
            //                     new XAttribute("SearchScope", model.SearchScope),
            //                     new XAttribute("xmls", "urn:OPUSSearch"),
            //                     new XElement("SearchBlock",
            //                     new XElement("Name",
            //                     new XAttribute("Value", model.AssetName),
            //                     new XAttribute("Operater", model.Operation)))).ToString();


            return sResult;
        }

    }
}
