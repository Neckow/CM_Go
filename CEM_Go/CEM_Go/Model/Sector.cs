using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CEM_Go.Model
{
    public class Sector
    {
        /* 
        "id": 1,
        "name": "Energie"
        */

        public int id { get; set; }
        public string name { get; set; }
    }
    public class AllSector
    {
        public List<Sector> sectors { get; set; }
    }


}
