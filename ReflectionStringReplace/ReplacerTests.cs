using FluentAssertions;

namespace ReflectionStringReplace;

public class ReplacerTests
{
    [Fact]
    public void ShouldReplaceWithObject()
    {
        ReplaceWith replaceWith = new (Key1:"VALUE1", Key2:"Value2");

        string actual = Replacer.Inject(Data.Template, replaceWith);
        actual.Should().Be(Data.Expected);
    }
}
public static class Data
{
public const string Template = @"
        Exerci clita $Key1$ lobortis. 
        Diam erat vero molestie $Key2$ consetetur. 
    ";

public const string Expected = @"
        Exerci clita VALUE1 lobortis. 
        Diam erat vero molestie Value2 consetetur. 
    ";
}
