using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Api.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                RepoAlumnos _alumnos = new RepoAlumnos();
                var alumnos = _alumnos.GetAlumnosFromJson();
                _alumnos.DeserializeJsonFile(alumnos);
                return Ok(alumnos.ToString());
            }catch
            {
                return BadRequest("Error");
            }
        }
        [HttpGet("{dni}")]
        public ActionResult<string> Get(string dni)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] Alumnos _alumnos)
        {
            RepoAlumnos _repoAlumnos = new RepoAlumnos();

            List<Alumnos> alumnos = new List<Alumnos>
            {
                new Alumnos
                {
                   dni = _alumnos.dni,
                   nombre = _alumnos.nombre,
                   apellido = _alumnos.apellido,
                   curso = _alumnos.curso,
                   año = _alumnos.año
                }
            };
            //alumnos.Add();
            var listAlumnos = alumnos;
            _repoAlumnos.SerializedJsonFile(listAlumnos);
        }
    }
}
