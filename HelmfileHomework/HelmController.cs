using Microsoft.AspNetCore.Mvc;

namespace HelmfileHomework;

[ApiController]
public class HelmController : Controller
{
    private readonly ReadinessProbeHealthCheck _readinessProbeHealthCheck;

    public HelmController(ReadinessProbeHealthCheck readinessProbeHealthCheck)
    {
        _readinessProbeHealthCheck = readinessProbeHealthCheck;
    }

    [HttpPost("switch-readiness")]
    public IActionResult SwitchReadiness()
    {
        _readinessProbeHealthCheck.IsReady = false;
        return Ok();
    }
}