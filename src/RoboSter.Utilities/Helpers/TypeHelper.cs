using System;
using System.Reflection;

namespace RoboSter.Utilities.Helpers
{
    public static class TypeHelper
    {
        public static bool HasAttribute<T>(this Type type) where T : Attribute =>
            Attribute.IsDefined(type, typeof(T));

        public static bool HasAttribute<T>(this MemberInfo info) where T : Attribute =>
            Attribute.IsDefined(info, typeof(T));
    }
}