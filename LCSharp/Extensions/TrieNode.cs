using System.Collections;
using System.Globalization;

class TrieNode<T>
{
    public T Value { get; set; }
    public bool IsEnd { get; set; }
    public List<TrieNode<T>> Children { get; }

    public TrieNode(T value, bool isEnd)
    {
        Value = value;
        IsEnd = isEnd;
        Children = new();
    }

    public TrieNode(T value)
    {
        Value = value;
        IsEnd = false;
        Children = new();
    }

    public TrieNode()
    {
        Value = default;
        IsEnd = false;
        Children = new();
    }
}