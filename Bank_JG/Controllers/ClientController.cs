using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistem.Application.Commands.Client;
using Sistem.Application.Interfaces;
using Sistem.Domain.Impl.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bank_JG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientAppService _clientAppService;

        public ClientController(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        [HttpPost("ResgistrarConta")]
        public async Task<IActionResult> ResgisterAccount(ClientCreateCommand command)
        {
            try
            {
              var client = await _clientAppService.Creat(command);
                return StatusCode(201, client); //CRIANDO
            }
            catch(ValidationException ex)
            {
                return StatusCode(400, ex.Message); // bad request
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message });// bad request
            }
            catch(Exception ex) 
            {
                return StatusCode(500, new { ex.Message }); // internal server error
            }
        }

        [HttpPut("EdicarConta")]
        public async Task<IActionResult> EditAccount(ClientUpdateCommand command)
        {
            try
            {
                var client = await _clientAppService.Update(command);
                return StatusCode(200, client); //ok
            }
            catch (ValidationException ex)
            {
                return StatusCode(400, ex.Message); // bad request
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message });// bad request
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message }); // internal server error
            }
        }

        [HttpDelete("DeletarConta/{id}")]
        public async Task<IActionResult> DeleteAccount(Guid id)
        {
            try
            {
                var command = new ClientDeleteCommand { Id = id };

                var client = await _clientAppService.Delete(command);
                return StatusCode(200, client); //ok
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { ex.Message });// bad request
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message }); // internal server error
            }
        }

        [HttpGet("ObterDetalhesDaConta/{id}")]
        public IActionResult GetAccountDetainls(Guid id)
        {
            return Ok();
        }

        [HttpGet("{page}/{limit}")]
        public IActionResult GetAll(int page, int limit)
        {
            return Ok();
        }
    }
}
