using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class StudentsDatabase
    {

        public List<string> firstName { get; set; }
        public List<string> lastName { get; set; }
        public List<int> date { get; set; }
        public List<int> fee { get; set; }
        public List<int> id { get; set; }


        public StudentsDatabase()
        {
            firstName = new List<string>();
            lastName = new List<string>();
            date = new List<int>();
            fee = new List<int>();
            id = new List<int>();

        }


    }
}
