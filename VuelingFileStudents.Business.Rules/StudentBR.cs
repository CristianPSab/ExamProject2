using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VuelingFileStudents.Infrastructure.Repository;
using VuelingFileStudents.Transversal.Utilities.Models;

namespace VuelingFileStudents.Business.Rules
{
 
    public class StudentBR
    {
        private readonly StudentRepository studentR = new StudentRepository();
        private readonly List<StudentModel> listStudent = new List<StudentModel>();

        public void ProcessStudentData(string name, string surname, DateTime birthday, string format)
        {
            var estudiante = new StudentModel(name, surname, birthday);
            estudiante.Id = estudiante.Id++;
            listStudent.Add(estudiante);
            ExportData(format);
        }

        private void ExportData(string format)
        {
            switch (format)
            {
                case ".txt":

                    studentR.ExportTXT(listStudent);
                    break;



                case ".xml":

                    studentR.ExportXML(listStudent);
                    break;



                case ".json":
                    studentR.ExportJson(listStudent);
                    break;



                default:
                    studentR.ExportTXT(listStudent);
                    break;
            }
        }

       
   
      

    }
}
