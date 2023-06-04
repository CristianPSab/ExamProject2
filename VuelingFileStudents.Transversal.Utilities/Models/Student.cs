using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFileStudents.Transversal.Utilities.Models
{
    public class Student
    {

        public int Id { get; set; }
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public Student() { }

        public Student(int id, string name, string surname, DateTime birthday)
        {
            Id = id;
            Guid = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Birthday = birthday.Date;
        }
    }
}
