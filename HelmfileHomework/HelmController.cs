using Microsoft.AspNetCore.Mvc;

namespace HelmfileHomework;

[ApiController]
public class HelmController : Controller
{
    private readonly ReadinessProbeProvider _readinessProbeProvider;

    public HelmController(ReadinessProbeProvider readinessProbeProvider)
    {
        _readinessProbeProvider = readinessProbeProvider;
    }

    [HttpPost("switch-readiness")]
    public IActionResult SwitchReadiness()
    {
        _readinessProbeProvider.IsReady = false;
        return Ok();
    }
}