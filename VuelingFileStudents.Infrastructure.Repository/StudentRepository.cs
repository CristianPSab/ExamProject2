using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VuelingFileStudents.Transversal.Utilities.Models;

namespace VuelingFileStudents.Infrastructure.Repository
{
    public class StudentRepository
    {
        public static string nombreArchivo = "ficheroEstudiantes";
        public void ExportJson(List<StudentModel> studentModel)
        {
            var path = $"{nombreArchivo}.json";
            string jsonString = JsonConvert.SerializeObject(studentModel);
            File.WriteAllText(path, jsonString);

        }

        public void ExportTXT(List<StudentModel> studentModel)
        {
            var path = $"{nombreArchivo}.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                foreach (var student in studentModel)
                {
                    sw.WriteLine(student.ToString());
                }
            }
        }



        public void ExportXML(List<StudentModel> studentModel)
        {
            var path = $"{nombreArchivo}.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<StudentModel>));

            using (StreamWriter fileWriter = new StreamWriter(path))
            {
                serializer.Serialize(fileWriter, studentModel);
            }
        }

       
    }
}
