using Core.Exceptions;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IService _gameService;

        public GameController(IService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("lastPlayer")]
        public IActionResult GetLastPlayer(int NumberofTotal)
        {
            try
            {
                var player = new Player { PlayerNumber = NumberofTotal };
                int lastPlayerNumber = _gameService.GetLastPlayer(player);
                return Ok($"Son kalan oyuncu: {lastPlayerNumber}");
            }
            catch (CException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Bir hata oluştu");
            }
        }
    }
}
