using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/sedes")]
    [ApiController]

    public class SedeController : ControllerBase
    {
        
        private ISedeService sedeService;

        public SedeController(ISedeService sedeService)
        {
            this.sedeService = sedeService;
        }

        /// <summary>
        /// Me permite devolver todas las sedes
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                sedeService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar una sede
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Sede sede)
        {
            return Ok(
                sedeService.Save(sede)
            );
        }


        /// <summary>
        /// Me permite devolver una sede dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                sedeService.Get(id)
            );
        }


        /// <summary>
        /// Me permite cargar todas las sedes
        /// </summary>
        /// <returns></returns>

        [HttpGet("cargar")]
        public ActionResult Get2()
        {
            return Ok(
                sedeService.Cargar()
            );
        }


    }


}