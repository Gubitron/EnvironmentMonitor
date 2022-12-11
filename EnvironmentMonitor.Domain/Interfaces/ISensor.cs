namespace EnvironmentMonitor.Domain.Interfaces;

public interface ISensor
{
    public Guid SensorId { get; }
    public string TypeName { get; }
}
