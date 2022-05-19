using Microsoft.AspNetCore.Mvc;
using Concessionaria.Lib.Models;

using Concessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        public static List<PessoaDTO> PessoasDaClasse { get; set; } = new List<PessoaDTO>();

        [HttpGet("Get PessoaDaClasse")]
        public IActionResult GetPessoaDaClasse()
        {
            return Ok(PessoasDaClasse);
        }

         [HttpPost("Set PessoaDaClasse")]
        public IActionResult SetPessoaDaClasse(PessoaDTO pessoaDTO)
        {
            var pessoa = new Pessoa(pessoaDTO.Nome, pessoaDTO.CPF, pessoaDTO.DataNasc.ToString());
            PessoasDaClasse.Add(pessoaDTO);
            return Ok(PessoasDaClasse);
        }
    }
}