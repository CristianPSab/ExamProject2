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
        StudentRepository studentRepository = new StudentRepository();
        List<Transversal.Utilities.Models.StudentModel> student = new List<Transversal.Utilities.Models.StudentModel>();
        public List<StudentModel> SaveToJson ()
        {
            
            string json = string .Empty;
            if(json.Equals(false))
            {

            //    var saveJson = studentR.SaveFileJson();
            }

            return null;
           
        }

   
        public List<StudentModel>   SaveToTXT(StudentModel studentModel)
        {

            var studentRepository = new VuelingFileStudents.Infrastructure.Repository.StudentRepository();
            var ExportTxt = studentRepository.ExportTXT(studentModel);

          
          
        
            return student.ToList();
        }

        public object SaveToXML()
        {
            string xml = string.Empty;
            if(xml.Equals(false))
            {
            //    var saveXml = studentR.SaveFileXML(); 
            }

            return null;
        }
    }
}
