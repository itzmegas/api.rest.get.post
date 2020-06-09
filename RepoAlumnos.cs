using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Api.Rest
{
    public class RepoAlumnos
    {
        public static string _path = @"C:\Users\itzmegas\Desktop\terciario\Programación 5\ApiRest\Api.Rest\Json_Ejemplo.json";

        public string GetAlumnosFromJson()
        {
            string AlumnosFromJson;
            using (var reader = new StreamReader(_path))
            {
                AlumnosFromJson = reader.ReadToEnd();
            }
            return AlumnosFromJson;
        }
        public void SerializedJsonFile(List<Alumnos> alumnos)
        {
            string alumnoJson = JsonConvert.SerializeObject(alumnos.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, alumnoJson);
        }
        public void DeserializeJsonFile(string alumnosFromJson)
        {
            JsonConvert.DeserializeObject<List<Alumnos>>(alumnosFromJson);
        }
    }
}
