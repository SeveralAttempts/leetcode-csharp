using LCSharp;

namespace Tests;

public class WordBreak
{
    [Fact]
    public void WordBreak_1()
    {
        var inst = new LeetcodeTasks();

        var words = new List<string> { "leet", "code" };

        var actual = inst.WordBreak("leetcode", words);

        Assert.True(actual);
    }

    [Fact]
    public void WordBreak_2()
    {
        var inst = new LeetcodeTasks();

        var words = new List<string> { "apple", "pen" };

        var actual = inst.WordBreak("applepenapple", words);

        Assert.True(actual);
    }

    [Fact]
    public void WordBreak_3()
    {
        var inst = new LeetcodeTasks();

        var words = new List<string> { "cats", "dog", "sand", "and", "cat" };

        var actual = inst.WordBreak("catsandog", words);

        Assert.False(actual);
    }

    [Fact]
    public void WordBreak_4()
    {
        var inst = new LeetcodeTasks();

        var words = new List<string> { "car", "ca", "rs" };

        var actual = inst.WordBreak("cars", words);

        Assert.False(actual);
    }
}