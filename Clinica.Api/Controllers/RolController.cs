using Microsoft.AspNetCore.Mvc;
using Clinica.Entity;
using Clinica.Service;

namespace Clinica.Api.Controllers
{
    [Route("api/roles")]
    [ApiController]

    public class RolController : ControllerBase
    {
        
        private IRolService rolService;

        public RolController(IRolService rolService)
        {
            this.rolService = rolService;
        }

        /// <summary>
        /// Me permite devolver todas los roles
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                rolService.GetAll()
            );
        }


        /// <summary>
        /// Me permite ingresar un rol
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Post([FromBody] Rol rol)
        {
            return Ok(
                rolService.Save(rol)
            );
        }


        /// <summary>
        /// Me permite devolver un rol dependiendo de su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                rolService.Get(id)
            );
        }


    }


}