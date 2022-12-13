using EnvironmentMonitor.Domain.Interfaces;

namespace EnvironmentMonitor.Domain.Entities;

public class TemperatureHumidityReading
{
    private const string DATA_DELIMITER = ",";

    private IDateTime _dateTime;

    public Guid SensorReadingId { get; }
    public Guid SensorId { get; }
    public DateTime DateTime { get; private set; }
    public decimal TemperatureOneWire { get; private set; }
    public decimal TemperatureDht { get; private set; }
    public decimal RelativeHumidityDht { get; private set; }
    public decimal HeatIndex { get; private set; }
    public decimal BatteryVoltage { get; private set; }
    public decimal BatteryVoltageRaw { get; private set; }

    public TemperatureHumidityReading(Guid sensorId, string data, IDateTime dateTime)
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
            TemperatureOneWire = decimal.Parse(dataList[0]);
            BatteryVoltage = decimal.Parse(dataList[1]);
            BatteryVoltageRaw = decimal.Parse(dataList[2]);
            RelativeHumidityDht = decimal.Parse(dataList[3]);
            TemperatureDht = decimal.Parse(dataList[4]);
            HeatIndex = decimal.Parse(dataList[5]);
        }
        catch
        {
            // TODO: implement logging
        }

    }
}
