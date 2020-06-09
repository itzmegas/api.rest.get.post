using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Rest
{
    public class Alumnos
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string curso { get; set; }
        public int año { get; set; }
    }
}
