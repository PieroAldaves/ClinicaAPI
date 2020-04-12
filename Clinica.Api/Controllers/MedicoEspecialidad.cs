using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;
using Clinica.Repository.ViewModel;

namespace Clinica.Api.Controllers
{
    [Route("api/medicoespecialidades")]
    [ApiController]

    public class MedicoEspecialidadController : ControllerBase
    {
        
        private IMedicoEspecialidadService medicoespecialidadService;

        public MedicoEspecialidadController(IMedicoEspecialidadService medicoespecialidadService)
        {
            this.medicoespecialidadService = medicoespecialidadService;
        }

        /// <summary>
        /// Me permite devolver todas las medicoespecialidades
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                medicoespecialidadService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar un medicoespecialidad
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] MedicoEspecialidad medicoespecialidad)
        {
            return Ok(
                medicoespecialidadService.Save(medicoespecialidad)
            );
        }


        /// <summary>
        /// Me permite devolver un medicoespecialidad dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                medicoespecialidadService.Get(id)
            );
        }


    }


}