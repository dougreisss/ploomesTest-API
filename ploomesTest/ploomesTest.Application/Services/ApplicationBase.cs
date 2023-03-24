using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class ApplicationBase
    {
        public static T Read<T>(object from) where T : class, new()
        {
            T val = new T();
            if (from != null)
            {
                Type type = from.GetType();
                Type type2 = val.GetType();

                PropertyInfo[] properties = type.GetProperties();
                PropertyInfo[] properties2 = type2.GetProperties();
                foreach (PropertyInfo prpTo in properties2)
                {
                    IEnumerable<PropertyInfo> source = properties.Where((PropertyInfo x) => x.Name.ToLower() == prpTo.Name.ToLower() && x.GetType() == prpTo.GetType());
                    if (source.Any() && prpTo.CanWrite)
                    {
                        object value = source.First().GetValue(from, null);
                        if (!IsList(value))
                        {
                            prpTo.SetValue(val, value);
                        }
                    }
                }
            }
            return val;
        }
        public static List<T> List<T>(IEnumerable<object> listFrom) where T : class, new()
        {
            List<T> list = new List<T>();

            foreach (object item2 in listFrom)
            {
                T item = Read<T>(item2);
                list.Add(item);
            }

            return list;
        }

        private static bool IsList(object o)
        {
            if (o == null)
            {
                return false;
            }

            if (o is IList && o.GetType().IsGenericType)
            {
                return o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
            }

            return false;
        }
    }
}
