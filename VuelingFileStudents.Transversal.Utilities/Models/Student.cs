using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelingFileStudents.Transversal.Utilities.Models
{
    public class Student
    {

        public int Id { get; set; }
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTimePicker Birthday { get; set; }
        public DateTimePicker Birthday1 { get; }

        public Student() { }

        public Student(int id,string name, string surname, DateTimePicker birthday)
        {
            Id = id;
            Guid = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public Student(string name, string surname, DateTimePicker birthday)
        {
            Name = name;
            Surname = surname;
            Birthday1 = birthday;
        }
    }
}
