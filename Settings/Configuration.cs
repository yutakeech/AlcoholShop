using SimpleInjector;

namespace Settings;

public class Configuration
{
    public Container Container { get; }
    public virtual void Setup()
    {}
}