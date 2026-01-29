using LCSharp;

namespace Tests;

public class CountSubstringsTests
{
    [Fact]
    public void CountSubstrings_1()
    {
        var inst = new LeetcodeTasks();

        var actual = inst.CountSubstrings("abc");

        Assert.Equal(3, actual);
    }

    [Fact]
    public void CountSubstrings_2()
    {
        var inst = new LeetcodeTasks();

        var actual = inst.CountSubstrings("aaa");

        Assert.Equal(6, actual);
    }
}