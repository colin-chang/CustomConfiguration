using System;
using System.Timers;
using Microsoft.Extensions.Configuration;

namespace ColinConfiguration
{
    class ColinConfigurationProvider : ConfigurationProvider
    {
        private Timer _timer;

        public ColinConfigurationProvider()
        {
            _timer = new Timer {Interval = 3000};
            _timer.Elapsed += (s, e) => Load(true);
            _timer.Start();
        }

        public override void Load() => Load(false);

        private void Load(bool reload)
        {
            //模拟配置动态更新
            Data["LastUpdatedTime"] = DateTime.Now.ToString();
            if (reload)
                OnReload();
        }
    }
}