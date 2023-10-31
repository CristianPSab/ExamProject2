using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelingFileStudents.Transversal.Utilities.Models
{
    public class StudentModel
    {

        public int Id { get; set; }
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public int Age { get; set; }

        public StudentModel() { }


        public StudentModel(string name, string surname, DateTime birthday)
        {
           
            Guid = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Birthday = birthday;

            Age = CalculateAge(birthday);
        }

        public override bool Equals(object obj)
        {
            return obj is StudentModel model &&
                   Id == model.Id &&
                   Guid.Equals(model.Guid) &&
                   Name == model.Name &&
                   Surname == model.Surname &&
                   EqualityComparer<DateTime>.Default.Equals(Birthday, model.Birthday);
        }

        public override int GetHashCode()
        {
            int hashCode = 6628628;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Guid.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(Birthday);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Id: , {Id}  , " +
               $"Guid: , {Guid} ," +
               $"Name: , {Name} ," +
               $"Surname: , {Surname} ," +
               $"Birthday: , {Birthday} ," +
               $"Age: , {Age}";
        }

        public static int CalculateAge(DateTime birthday)
        {
            var today = DateTime.Today;
            var ages = today.Year - birthday.Year;
            if (birthday > today.AddYears(ages))
            {
                ages--;
            }
            return ages;
        }
    }
}
