using System.Reflection;
using System.Text;

namespace ReflectionStringReplace;
public static class Replacer
{
    public static string Inject(string template, IReplaceKVP replaceWith, string delimiter="$")
    {
        StringBuilder retVal = new(template);
        replaceWith.ToMappingDictionary().ToList().ForEach(kvp => retVal.Replace($"{delimiter}{kvp.Key}{delimiter}", kvp.Value));
        return retVal.ToString();
    }
}