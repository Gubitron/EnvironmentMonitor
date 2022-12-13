using EnvironmentMonitor.Domain.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace EnvironmentMonitor.Domain.Entities;

public class CurrentClampReading
{
    private const string DATA_DELIMITER = ",";

    private IDateTime _dateTime;

    public Guid SensorReadingId { get; }
    public Guid SensorId { get; }
    public DateTime DateTime { get; private set; }
    public decimal Current { get; private set; }
    public decimal Power { get; private set; }

    public CurrentClampReading(Guid sensorId, string data, IDateTime dateTime)
    {
        _dateTime = dateTime;

        SensorReadingId = Guid.NewGuid();
        SensorId = sensorId;
        ParseDataString(data);
    }

    private void ParseDataString(string data)
    {
        var dataList = data.Split(DATA_DELIMITER).SkipLast(1).ToList();

        DateTime = _dateTime.Now;
        try
        {
            Current = decimal.Parse(dataList[0]);
            Power = decimal.Parse(dataList[1]);
        }
        catch
        {
            // TODO: implement logging
        }

    }
}
