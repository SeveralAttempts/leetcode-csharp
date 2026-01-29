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

    public string LongestPalindrome(string s)
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j + i < s.Length; j++)
            {
                if (s[j] == s[i + j])
                {
                    bool res = false;
                    int l = j, r = i + j;
                    while (l <= r)
                    {
                        if (s[l] != s[r])
                        {
                            res = false;
                            break;
                        }
                        else
                        {
                            res = true;
                        }
                        ++l;
                        --r;
                    }

                    if (res) return s.Substring(j, i + 1);
                }
            }
        }

        return s[0].ToString();
    }

    public int CountSubstrings(string s)
    {
        int count = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j + i < s.Length; j++)
            {
                if (s[j] == s[i + j])
                {
                    bool res = false;
                    int l = j, r = i + j;
                    while (l <= r)
                    {
                        if (s[l] != s[r])
                        {
                            res = false;
                            break;
                        }
                        else
                        {
                            res = true;
                        }
                        ++l;
                        --r;
                    }

                    if (res) count++;
                }
            }
        }

        return count;
    }
    
    public bool WordBreak(string s, IList<string> wordDict) {
        List<string> list = wordDict.ToList();
        int i = 0;
        while (i < s.Length)
        {
            int add = 1;
            bool isSame = false;
            for (int j = 0; j < list.Count; j++)
            {
                if (i + list[j].Length > s.Length)
                    continue;

                if (list[j] == s.Substring(i, list[j].Length))
                {
                    isSame = true;
                    add = list[j].Length;
                    break;
                }
            }

            if (!isSame) return false;

            // TODO

            i += add;
        }

        return true;
    }
}