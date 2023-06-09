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
            var provando = studentModel.ToString();

            string path = "C:\\Users\\cristianps\\Documents\\Ficheros\\ficheroTxt.txt";

            //// Create an instance of StreamReader to read from a file.
            //// The using statement also closes the StreamReader.

            //using (StreamReader sr = new StreamReader(path))
            //{
            //    string line;
            //    // Read and display lines from the file until the end of
            //    // the file is reached.
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //using (StreamWriter outputF = new StreamWriter(path))
            //{

            //    outputF.WriteLine(provando);

            //}

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(provando);
            }


            return "";
        }

        public string ExportXML()
        {
            return "";
        }
    }
}
