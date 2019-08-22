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
           
            var search = new SearchModel();
            var searchBlock = new SearchBlock();
            var searchParams = new SearchParams();

            searchParams.SearchName = assetName;
            searchParams.Operator = "Containts";
            searchBlock.searchParams = searchParams;
            search.SearchScope = searchScope;
            search.searchBlock.Add(searchBlock);

            var sResult = Serializer.Serialize<SearchModel>(search);
            return sResult;
        }

    }
}
