using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HelmfileHomework;

public class ReadinessProbeHealthCheck : IHealthCheck
{
    public bool IsReady { get; set; } = true;

    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(IsReady
            ? HealthCheckResult.Healthy("The system is ready.")
            : HealthCheckResult.Unhealthy("The system is not ready."));
    }
}