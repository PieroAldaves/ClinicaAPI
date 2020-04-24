using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/medicos")]
    [ApiController]

    public class MedicoController : ControllerBase
    {
        
        private IMedicoService medicoService;

        public MedicoController(IMedicoService medicoService)
        {
            this.medicoService = medicoService;
        }

        /// <summary>
        /// Me permite devolver todas las medicoes
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                medicoService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar una medico
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Medico medico)
        {
            return Ok(
                medicoService.Save(medico)
            );
        }


        /// <summary>
        /// Me permite devolver una medico dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                medicoService.Get(id)
            );
        }

        /// <summary>
        /// Me permite devolver una medico dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("cargar")]
        public ActionResult Get2()
        {
            return Ok(
                medicoService.Cargar()
            );
        }


    }


}