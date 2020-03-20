using System;

namespace RoboSter.Utilities.Configuration
{
    public interface IConfig
    {
        string GetValue(string key);
        T GetValue<T>(string key, Func<string, T> converter);
    }
}