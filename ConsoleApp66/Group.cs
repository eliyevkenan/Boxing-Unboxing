using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp66
{
    internal class Group
    {
        private static int _noD = 100;
        private static int _noP = 100;
        private static int _noS = 100;
        private static string _nostr =" ";
        public Group(GroupType type)
        {
            this.Type = type;
            switch (type)
            {
                case GroupType.Desing:
                    _noD++;
                    _nostr =_nostr+("D"+_noD);
                    break;
                case GroupType.System:
                    _noS++;
                    _nostr =_nostr+("S"+_noS);
                    break;
                case GroupType.Programming:
                    _noP++;
                    _nostr =_nostr+("P"+_noP);
                    break; 
            }
            this.No = _nostr;
        }

        public GroupType Type { get; set; }
        public string No { get; }
        public Student[] students { get; set; }
        public Student FindStudentByNo(int no)
        {
            foreach (Student student in this.students)
            {
                if (student.No == no)
                {
                    return student;
                }
            }
        }
    }
}
