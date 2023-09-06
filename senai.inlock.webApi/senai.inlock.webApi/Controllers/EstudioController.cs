using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System.Data;

namespace senai.inlock.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }
    /// <summary>
    /// Endpoint que aciona o método de cadastro de estudios
    /// </summary>
    /// <param name="novoEstudio">Objeto recebido na requisiçao</param>

        [HttpPost]
        public IActionResult Post(EstudioDomain novoEstudio)
        {
            try
            {
                _estudioRepository.Cadastrar(novoEstudio);

                return Created("Objeto criado", novoEstudio);

            }
            catch (Exception erro)
            {
                //Retorna um status code BadRequest(400)
                return BadRequest(erro.Message);
            }
        }

    }

}
