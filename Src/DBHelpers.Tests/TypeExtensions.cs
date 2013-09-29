using System;
using System.Linq;
using System.Reflection;

namespace DBHelpers.Tests
{
    public static class TypeExtensions
    {
        public static string[] GetSignatures(this Type type, string methodName, BindingFlags flags)
        {
            var methods = type.GetMethods(flags).Where(m => m.Name == methodName);

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
