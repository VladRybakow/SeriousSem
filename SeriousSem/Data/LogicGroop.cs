using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriousSem.Data
{
    public class LogicGroop
    {
        public string name;
        public string surname;
        public int group;
        public string faculty;

        public LogicGroop(string name, string surname, int group, string faculty)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.faculty = faculty;
        }

        public static List<LogicGroop> GetStudents()
        {
            List<LogicGroop> list = new List<LogicGroop>();
            list.Add(new LogicGroop("Ivan", "Ivanov", 222, "ab"));
            list.Add(new LogicGroop("Bulka", "Bulov", 221, "abd"));
            list.Add(new LogicGroop("Iskander", "Iskov", 202, "a"));
            list.Add(new LogicGroop("Andrey", "Ibanov", 321, "b"));
            return list;
        }
    }
}
