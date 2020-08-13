using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace ConfigurationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddColinConfiguration(); //使用自定义配置源
            var configurationRoot = builder.Build();
            //Console.WriteLine(configurationRoot["LastUpdatedTime"]);

            ChangeToken.OnChange(
                () => configurationRoot.GetReloadToken(),
                () => Console.WriteLine(configurationRoot["LastUpdatedTime"]));

            Console.ReadKey();
        }
    }
}