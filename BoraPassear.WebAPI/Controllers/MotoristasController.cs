using BoraPassear.WebAPI.Infrastructure;
using BoraPassear.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoraPassear.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristasController : ControllerBase
    {
        private readonly ApplicationContext _appContext;

        public MotoristasController(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public IActionResult Get()
        { 
            return Ok(_appContext.Motoristas.ToList());
        }
        
        [HttpPost]
        public IActionResult Post(Motorista novoMotorista)
        {
            _appContext.Motoristas.Add(novoMotorista);
            _appContext.SaveChanges();
            return Ok(novoMotorista);
        }
    }
}
