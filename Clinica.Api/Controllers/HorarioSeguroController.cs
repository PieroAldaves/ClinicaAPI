using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;
using Clinica.Repository.ViewModel;

namespace Clinica.Api.Controllers
{
    [Route("api/horarioseguros")]
    [ApiController]

    public class HorarioSeguroController : ControllerBase
    {
        
        private IHorarioSeguroService horarioseguroService;

        public HorarioSeguroController(IHorarioSeguroService horarioseguroService)
        {
            this.horarioseguroService = horarioseguroService;
        }

        /// <summary>
        /// Me permite devolver todas las horarioseguroes
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                horarioseguroService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar una horarioseguro
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] HorarioSeguro horarioseguro)
        {
            return Ok(
                horarioseguroService.Save(horarioseguro)
            );
        }


        /// <summary>
        /// Me permite devolver una horarioseguro dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                horarioseguroService.Get(id)
            );
        }


    }


}