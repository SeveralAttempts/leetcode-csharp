using LCSharp;

namespace Tests;

public class LCTests
{
    [Fact]
    public void LengthOfLongestSubstring_1()
    {
        var mtdStore = new LeetcodeTasks();

        int actual = mtdStore.LengthOfLongestSubstring("abcabcbb");

        Assert.Equal(3, actual);
    }

    [Fact]
    public void LengthOfLongestSubstring_2()
    {
        var mtdStore = new LeetcodeTasks();

        int actual = mtdStore.LengthOfLongestSubstring("bbbbb");

        Assert.Equal(1, actual);
    }

    [Fact]
    public void LengthOfLongestSubstring_3()
    {
        var mtdStore = new LeetcodeTasks();

        int actual = mtdStore.LengthOfLongestSubstring("pwwkew");

        Assert.Equal(3, actual);
    }

    [Fact]
    public void LengthOfLongestSubstring_4()
    {
        var mtdStore = new LeetcodeTasks();

        int actual = mtdStore.LengthOfLongestSubstring("aab");

        Assert.Equal(2, actual);
    }
    
    [Fact]
    public void LengthOfLongestSubstring_5()
    {
        var mtdStore = new LeetcodeTasks();

        int actual = mtdStore.LengthOfLongestSubstring("dvdf");
        
        Assert.Equal(3, actual);
    }
}
