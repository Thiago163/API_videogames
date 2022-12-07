using Api_videogames.DAO;
using Api_videogames.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_videogames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Listar()
        {
            VideogameDAO dao = new VideogameDAO();
            var videogames = dao.Listar();
            return Ok(videogames);
        }

        [HttpPost]
        public IActionResult Cadastrar(VideogameDTO videogame)
        {
            VideogameDAO dao = new VideogameDAO();
            dao.Cadastrar(videogame);
            return Ok();
        }

        [HttpPut]
        public IActionResult Alterar(VideogameDTO videogame)
        {
            VideogameDAO dao = new VideogameDAO();
            dao.Alterar(videogame);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Remover(int id)
        {
            VideogameDAO dao = new VideogameDAO();
            dao.Remover(id);
            return Ok();
        }
    }
}
