using LCSharp;

namespace Tests;

public class LongestPalindrome
{
    [Fact]
    public void LongestPalindrome_1()
    {
        var inst = new LeetcodeTasks();

        var actual = inst.LongestPalindrome("babad");

        var acceptableValues = new List<string> { "bab", "aba" };

        Assert.Contains(actual, acceptableValues);
    }

    [Fact]
    public void LongestPalindrome_2()
    {
        var inst = new LeetcodeTasks();

        var actual = inst.LongestPalindrome("cbbd");

        Assert.Equal("bb", actual);
    }

    [Fact]
    public void LongestPalindrome_3()
    {
        var inst = new LeetcodeTasks();

        var actual = inst.LongestPalindrome("abbcccba");

        Assert.Equal("bcccb", actual);
    }
}