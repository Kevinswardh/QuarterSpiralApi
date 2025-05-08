using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace QuarterSpiralApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GridController : ControllerBase
    {
        private readonly string _filePath = Path.Combine("Data", "grid.json");

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                if (!System.IO.File.Exists(_filePath))
                {
                    return NotFound("Ingen sparad grid hittades.");
                }

                var json = System.IO.File.ReadAllText(_filePath);
                return Content(json, "application/json");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ett fel uppstod vid hämtning av rutnät: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] string[][] grid)
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }

                var json = JsonSerializer.Serialize(grid, new JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(_filePath, json);

                return Ok("Rutnätet sparades korrekt.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ett fel uppstod vid sparning av rutnät: {ex.Message}");
            }
        }

        [HttpDelete("clear")]
        public IActionResult Clear()
        {
            try
            {
                if (System.IO.File.Exists(_filePath))
                {
                    System.IO.File.Delete(_filePath);
                    return Ok("Rutnätet rensades.");
                }

                return NotFound("Ingen fil att radera.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ett fel uppstod vid rensning: {ex.Message}");
            }
        }
    }
}
