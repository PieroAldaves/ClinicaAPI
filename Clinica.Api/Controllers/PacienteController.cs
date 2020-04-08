using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/pacientes")]
    [ApiController]

    public class PacienteController : ControllerBase
    {
        
        private IPacienteService pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            this.pacienteService = pacienteService;
        }

        /// <summary>
        /// Me permite devolver todos los pacientees
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                pacienteService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar un paciente
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Paciente paciente)
        {
            return Ok(
                pacienteService.Save(paciente)
            );
        }


        /// <summary>
        /// Me permite devolver un paciente dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                pacienteService.Get(id)
            );
        }


    }


}