using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/especialidades")]
    [ApiController]

    public class EspecialidadController : ControllerBase
    {
        
        private IEspecialidadService especialidadService;

        public EspecialidadController(IEspecialidadService especialidadService)
        {
            this.especialidadService = especialidadService;
        }

        /// <summary>
        /// Me permite devolver todas las especialidades
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                especialidadService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar una especialidad
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Especialidad especialidad)
        {
            return Ok(
                especialidadService.Save(especialidad)
            );
        }


        /// <summary>
        /// Me permite devolver una especialidad dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                especialidadService.Get(id)
            );
        }


        /// <summary>
        /// Me permite devolver todas las especialidades
        /// </summary>
        /// <returns></returns>

        [HttpGet("cargar")]
        public ActionResult Get2()
        {
            return Ok(
                especialidadService.Cargar()
            );
        }


    }


}