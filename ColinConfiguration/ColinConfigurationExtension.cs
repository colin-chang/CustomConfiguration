using ColinConfiguration;

namespace Microsoft.Extensions.Configuration
{
    public static class ColinConfigurationExtension
    {
        public static IConfigurationBuilder AddColinConfiguration(this IConfigurationBuilder builder)
        {
            builder.Add(new ColinConfigurationSource());
            return builder;
        }
    }
}