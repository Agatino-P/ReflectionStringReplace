using System.Linq;
using System.Reflection;

namespace ReflectionStringReplace;
public interface IReplaceKVP
{
    IDictionary<string,string> ToMappingDictionary()
    {
        PropertyInfo[] properties = this.GetType().GetProperties();
        Dictionary<string, string> retval =
            properties.ToDictionary(property => property.Name, property => (property.GetValue(this) as string)!);
        return retval;
    }

}

public record ReplaceWith(string Key1 = "value1", string Key2 = "value2") : IReplaceKVP { }
