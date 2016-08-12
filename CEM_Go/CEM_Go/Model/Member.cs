

namespace CEM_Go.Model
{
    public class Member
    {
        public  int id { get; set; }
        public string name { get; set; }
        public string qualification { get; set; }

        //public string photoPath { get; set; } 

    }

    public class Rootobject
        {
            public Member[] members { get; set; }
        }
}
