using System;
using System.Linq;
using System.Reflection;

namespace DBHelpers.Tests
{
    public static class TypeExtensions
    {
        public static string[] GetSignatures(this Type type, string methodName, bool staticMembers)
        {
            var bindingFlags = BindingFlags.Public | (staticMembers ? BindingFlags.Static : BindingFlags.Instance);

            var methods = type.GetMethods(bindingFlags).Where(m => m.Name == methodName);

            var signatures = methods.Select(m =>
            {
                var returnType = GetTypeName(m.ReturnType);
                var argumentTypes = m.GetParameters().Select(p => GetTypeName(p.ParameterType));

                return String.Format("{0} {1}({2})", returnType, methodName, String.Join(", ", argumentTypes));
            });

            return signatures.ToArray();
        }

        public static string GetTypeName(Type type)
        {
            if (type == typeof(int))
                return "int";

            if (type == typeof(object))
                return "object";

            if (type == typeof(string))
                return "string";

            if (type.IsGenericType)
            {
                var name = type.Name.Split('`')[0];
                var genericArguments = type.GetGenericArguments().Select(t => GetTypeName(t));

                return String.Format("{0}<{1}>", name, String.Join(", ", genericArguments));
            }

            return type.Name;
        }
    }
}
