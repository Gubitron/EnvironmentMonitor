using EnvironmentMonitor.Domain.Interfaces;

namespace EnvironmentMonitor.Infrastructure
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}