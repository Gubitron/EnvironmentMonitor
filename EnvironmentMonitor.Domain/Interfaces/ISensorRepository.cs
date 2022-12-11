namespace EnvironmentMonitor.Domain.Interfaces;

public interface ISensorRepository
{
    void Add(ISensor sensor);
    bool Delete(ISensor sensor);
    IEnumerable<ISensor> GetAll();
    IEnumerable<ISensor> GetByName(string name);
    IEnumerable<ISensor> GetById(Guid id);
}
