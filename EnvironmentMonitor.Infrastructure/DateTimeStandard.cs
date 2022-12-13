using EnvironmentMonitor.Domain.Interfaces;

namespace EnvironmentMonitor.Infrastructure
{
    public class DateTimeStandard : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}