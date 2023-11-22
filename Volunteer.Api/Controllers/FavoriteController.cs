using Microsoft.AspNetCore.Mvc;
using Volunteer.Core.Favorites;
using Volunteer.Data.Favorites;

namespace volunteer.Controllers
{
    [ApiController]
    [Route("api")]
    public class FavoriteController : ControllerBase
    {
        private readonly FavoriteService _favoriteService;
        private readonly string _connectionString;

        public FavoriteController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _favoriteService = new FavoriteService(new FavoriteRepository(_connectionString));
        }

        [HttpGet("favorites/{UserId}")]
        public IActionResult GetFavorites(string UserId)
        {
            try
            {
                IEnumerable<Favorite> favorites = _favoriteService.GetFavorites(UserId);
                return Ok(favorites);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPost("favorite")]
        public IActionResult AddFavorite(Favorite favorite)
        {
            try
            {
                Favorite newFavorite = _favoriteService.AddFavorite(favorite);
                return Ok(newFavorite);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpDelete("favorite/{Id}")]
        public IActionResult RemoveFavorite(int Id)
        {
            try
            {
                Favorite favorite = _favoriteService.RemoveFavorite(Id);
                return Ok(favorite);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}
