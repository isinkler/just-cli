using System;
using System.ComponentModel;
using System.Reflection;

namespace JustCli
{
    public static class Extensions
    {
        public static T GetValueFromDescription<T>(string description)
        {
            Type type = typeof(T);

            if (!type.IsEnum)
            {
                throw new InvalidOperationException();
            }

            foreach (FieldInfo field in type.GetFields())
            {
                var descriptionAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (descriptionAttribute != null)
                {
                    if (descriptionAttribute.Description == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            return default;
        }
    }
}
