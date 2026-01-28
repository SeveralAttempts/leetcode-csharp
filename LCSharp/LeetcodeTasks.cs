using System.Runtime.InteropServices;

namespace LCSharp;

public class LeetcodeTasks
{
    public int LengthOfLongestSubstring(string s)
    {
        int actual = 0;
        HashSet<char> entries = new();

        for (int i = 0; i < s.Length; i++)
        {
            var slice = s.Substring(i, s.Length - i);
            foreach (var item in slice)
            {
                var isKey = entries.Contains(item);
                if (isKey)
                {
                    actual = entries.Count > actual ? entries.Count : actual;
                    entries.Clear();
                    break;
                }
                else
                {
                    entries.Add(item);
                }
            }
        }
        
        actual = entries.Count > actual ? entries.Count : actual;
        return actual;
    }
}