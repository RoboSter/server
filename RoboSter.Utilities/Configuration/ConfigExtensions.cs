namespace RoboSter.Utilities.Configuration
{
    public static class ConfigExtensions
    {
        public static bool IsProduction(this IConfig config)
        {
            return config.GetValue("isProduction",
                s => bool.TryParse(s, out var val) && val );
        }
    }
}