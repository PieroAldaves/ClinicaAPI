using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/seguros")]
    [ApiController]

    public class SeguroController : ControllerBase
    {
        
        private ISeguroService seguroService;

        public SeguroController(ISeguroService seguroService)
        {
            this.seguroService = seguroService;
        }

        /// <summary>
        /// Me permite devolver todos los seguros
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                seguroService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar un seguro
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Seguro seguro)
        {
            return Ok(
                seguroService.Save(seguro)
            );
        }


        /// <summary>
        /// Me permite devolver un seguro dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                seguroService.Get(id)
            );
        }


        /// <summary>
        /// Me permite cargar todos los seguros
        /// </summary>
        /// <returns></returns>

        [HttpGet("cargar")]
        public ActionResult Get2()
        {
            return Ok(
                seguroService.Cargar()
            );
        }


    }


    


}