using System.Reflection;

namespace BinbinAttribute
{
    public static class AttributeExtension
    {
        public static TAttribute Get<TAttribute>(this MemberInfo memberInfo)
            where TAttribute : System.Attribute
        {
            return System.Attribute.GetCustomAttribute(memberInfo, typeof(TAttribute)) as TAttribute;
        }
        public static TAttribute Get<TAttribute>(this Assembly memberInfo)
            where TAttribute : System.Attribute
        {
            return System.Attribute.GetCustomAttribute(memberInfo, typeof(TAttribute)) as TAttribute;
        }
        public static TAttribute Get<TAttribute>(this Module memberInfo)
            where TAttribute : System.Attribute
        {
            return System.Attribute.GetCustomAttribute(memberInfo, typeof(TAttribute)) as TAttribute;
        }
        public static TAttribute Get<TAttribute>(this ParameterInfo memberInfo)
            where TAttribute : System.Attribute
        {
            return System.Attribute.GetCustomAttribute(memberInfo, typeof(TAttribute)) as TAttribute;
        }
    }
}