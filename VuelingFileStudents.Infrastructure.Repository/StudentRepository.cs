using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFileStudents.Transversal.Utilities.Models;

namespace VuelingFileStudents.Infrastructure.Repository
{
    public class StudentRepository
    {
        public string ExportJson()
        {
            return "";
        }

        public string  ExportTXT(StudentModel studentModel)
        {
            var txt = studentModel.ToString();

            string path = "C:\\Users\\cristianps\\Documents\\Ficheros\\ficheroTxt.txt";


          
            
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(txt);
                }


            return "";
        }

        public string ExportXML()
        {
            return "";
        }
    }
}
