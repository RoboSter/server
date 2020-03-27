namespace RoboSter.Utilities.Configuration
{
    public static class ConfigExtensions
    {
        public static bool IsProduction(this IConfig config) => config.GetValue<bool>("isProduction");
    }
}