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


        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                especialidadService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Especialidad especialidad)
        {
            return Ok(
                especialidadService.Save(especialidad)
            );
        }


    }


}