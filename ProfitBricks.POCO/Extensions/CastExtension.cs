using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ProfitBricks.POCO.Extensions
{
    /// <summary>
    /// Extension to cast POCO.ProfitBricksBase objects into PB objects.
    /// </summary>
    public static class CastExtension
    {
        /// <summary>
        /// Casts POCO.ProfitBricksBase objects into PB objects.
        /// </summary>
        /// <typeparam name="T">Type to be returned</typeparam>
        /// <param name="myobj">POCO.ProfitBricksBase object to be casted.</param>
        /// <returns>T</returns>
        public static T Cast<T>(this ProfitBricksBase myobj)
        {
            Type objectType = myobj.GetType();
            Type target = typeof(T);
            var x = Activator.CreateInstance(target, false);
            var z = from source in objectType.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            var d = from source in target.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            List<MemberInfo> members = d.Where(memberInfo => d.Select(c => c.Name).ToList().Contains(memberInfo.Name)).ToList();

            PropertyInfo propertyInfo;
            object value;
            foreach (var memberInfo in members)
            {
                propertyInfo = typeof(T).GetProperty(memberInfo.Name);
                Debug.WriteLine(Regex.Replace(memberInfo.Name, "^[a-z]", m => m.Value.ToUpper()));
                var val = myobj.GetType().GetProperties().Where(p => p.Name == Regex.Replace(memberInfo.Name, "^[a-z]", m => m.Value.ToUpper())).FirstOrDefault();
                value = null;
                if (val != null)
                    value = val.GetValue(myobj, null);

                if (propertyInfo.PropertyType == typeof(string[]) && value is List<string>)
                {
                    propertyInfo.SetValue(x, (value as List<string>).ToArray(), null);
                }
                else
                {
                    propertyInfo.SetValue(x, value, null);
                }
            }
            return (T)x;
        }
    }
}
