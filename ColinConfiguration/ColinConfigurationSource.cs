using Microsoft.Extensions.Configuration;

namespace ColinConfiguration
{
    class ColinConfigurationSource : IConfigurationSource
    {
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new ColinConfigurationProvider();
        }
    }
}