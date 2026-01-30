using System.ComponentModel;

class Trie<T>
{
    private TrieNode<T> _current; 

    public TrieNode<T> Root { get; }

    public Trie()
    {
        Root = new();
        _current = Root;
    }

    public void AddToCurrent(T value, bool isEnd = false)
    {
        var node = new TrieNode<T>(value, isEnd);
        _current.Children.Add(node);
        _current = _current.Children.Find(x => x.Equals(node));
    }

    public void Reset() => _current = Root;
    public T Current() => _current.Value;
}