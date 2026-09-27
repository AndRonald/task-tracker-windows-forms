
using System.ComponentModel;
using System.Reflection;

namespace task_tracker.Entities.Enums
{
    public enum Status
    {
        [Description("To Do")]
        todo = 0,
        [Description("In Progress")]
        progress = 1,
        [Description("Done")]
        done = 2
    }

    public static class EnumExtensions
    {
        public static IList<T> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enum type");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }
            return list;
        }
        public static string GetDescription(Enum item)
        {
            Type type = item.GetType();
            FieldInfo fi = type.GetField(item.ToString());
            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return String.Empty;
        }
    }

}
