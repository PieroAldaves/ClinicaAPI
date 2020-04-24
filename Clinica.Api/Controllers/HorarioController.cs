using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/horarios")]
    [ApiController]

    public class HorarioController : ControllerBase
    {
        
        private IHorarioService horarioService;

        public HorarioController(IHorarioService horarioService)
        {
            this.horarioService = horarioService;
        }

        /// <summary>
        /// Me permite devolver todas las horarioes
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                horarioService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar una horario
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Horario horario)
        {
            return Ok(
                horarioService.Save(horario)
            );
        }


        /// <summary>
        /// Me permite devolver una horario dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                horarioService.Get(id)
            );
        }



        /// <summary>
        /// carga horarios
        /// </summary>
        /// <returns></returns>

        [HttpGet("cargar")]
        public ActionResult Get2()
        {
            return Ok(
                horarioService.CargarHorarios()
            );
        }


    }


}