using Microsoft.AspNetCore.Mvc;

namespace EventingApp.ApiService.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase;