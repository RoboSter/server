using System;
using System.Reflection;

namespace RoboSter.Utilities.Helpers
{
    public static class TypeHelper
    {
        public static bool HasAttribute<T>(this Type type) where T : Attribute =>
            type.GetCustomAttribute(typeof(T)) != null;
    }
}