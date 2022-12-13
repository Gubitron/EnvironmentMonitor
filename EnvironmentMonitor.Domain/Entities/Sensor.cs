namespace EnvironmentMonitor.Domain.Entities;

public class Sensor
{
    public Guid SensorId { get; }
    public string TypeName { get; }
    public string Description { get; set;  }

    public Sensor(string typeName, string description)
    {
        SensorId = Guid.NewGuid();
        TypeName = typeName;
        Description = description;
    }
}
