using System.Collections.ObjectModel;

namespace CEM_Go.Model
{
    public class Reference
    {
      /* "id": 1,
        "sector": "Energie",
        "client": "EDF",
        "project": "Colimo",
        "duration": 6,
        "logo":"/projet/machin.png",
        "logo client": "/projet/client.png",
        "description": "Ceci est un projet",
        "distribution": "B2B",
        "platform": "iOS",
        "link": "www.apps.com"*/

        public int id { get; set; }
        public string sector { get; set; }
        public string client { get; set; }
        public string project { get; set; }
        public int duration { get; set; }
        public string logo { get; set; }
        public string clientLogo { get; set; }
        public string description { get; set; }
        public string distribution { get; set; }
        public string platform { get; set; }
        public string link { get; set; }

    }

    public class AllReferences
    {
        public Reference[] references { get; set; }
    }

    /*Can be a distinct file*/
    public class GroupedReferenceModel : ObservableCollection<Reference>
    {
        public string LongName { get; set; }
    }
}

