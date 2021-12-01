using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    struct Student
    {
        public Student(string sureanme, bool hostelneed, int background, bool didwork, string degree, string language)
        {
            Surname = sureanme;
            HostelNeed = hostelneed;
            Background = background;
            DidWork = didwork;
            Degree = degree;
            Language = language;
        }

        public string Surname { get; set; }

        public bool HostelNeed { get; set; }

        public int Background { get; set; }

        public bool DidWork { get; set; }

        public string Degree { get; set; }

        public string Language { get; set; }
    }
}
