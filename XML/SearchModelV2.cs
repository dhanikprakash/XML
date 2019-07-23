using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    class SearchModelV2
    {
        public string SearchScope { get; private set; }
        public string AssetName { get; private set; }
        public  Operations Operation { get; set; }
        public SearchModelV2(string assetName, string searchScope)
        {
            AssetName = assetName;
            SearchScope = searchScope;

        }
    }

    public enum Operations
    {
        Contains, 
        BeginsWith, 
        EndsWith
    }
     
}
