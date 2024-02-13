using DockerComposeDemoApp.Data;
using DockerComposeDemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DockerComposeDemoApp.Controllers;
[ApiController]
[Route("[controller]")]
public class DriverController(ILogger<DriverController> logger, ApiDbContext context) : ControllerBase
{
    private readonly ILogger<DriverController> _logger = logger;
    private readonly ApiDbContext _context = context;

    [HttpGet("GetAllDrivers")]
    public async Task<IActionResult> Get()
    {
        var allDrivers = await _context.Drivers.ToListAsync();
        return Ok(allDrivers);
    }
    
    [HttpPost("CreateDriver")]
    public async Task<IActionResult> Add(Driver driver)
    {
        await _context.AddAsync(driver);
        await _context.SaveChangesAsync();
        return Ok();
    }
}
