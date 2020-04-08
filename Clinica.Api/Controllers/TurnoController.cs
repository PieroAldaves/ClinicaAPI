using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/turnos")]
    [ApiController]

    public class TurnoController : ControllerBase
    {
        
        private ITurnoService turnoService;

        public TurnoController(ITurnoService turnoService)
        {
            this.turnoService = turnoService;
        }

        /// <summary>
        /// Me permite devolver todas los turnoes
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                turnoService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar un turno
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Turno turno)
        {
            return Ok(
                turnoService.Save(turno)
            );
        }


        /// <summary>
        /// Me permite devolver un turno dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                turnoService.Get(id)
            );
        }


    }


}