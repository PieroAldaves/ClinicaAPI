        
using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/reservas")]
    [ApiController]

    public class ReservaController : ControllerBase
    {
        
        private IReservaService reservaService;

        public ReservaController(IReservaService reservaService)
        {
            this.reservaService = reservaService;
        }

        /// <summary>
        /// Me permite devolver todas las reservaes
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                reservaService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar una reserva
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Reserva reserva)
        {
            return Ok(
                reservaService.Save(reserva)
            );
        }


        /// <summary>
        /// Me permite devolver una reserva dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                reservaService.Get(id)
            );
        }


    }


}