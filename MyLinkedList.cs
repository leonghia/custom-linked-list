using System.Collections;

public class MyLinkedList<T> : IMyLinkedList<T?>
{
    private MyNode<T?>? _head;
    private int _count = 0;
    public int Count => _count;

    public bool IsReadOnly => false;

    public void Add(T? item) => AddToFront(item);

    public void AddToEnd(T? item)
    {
        var lastNode = GetNodes().Last();
        var newLastNode = new MyNode<T>(item);
        lastNode.Next = newLastNode;
        _count++;
    }

    public void AddToFront(T? item)
    {
        var newHead = new MyNode<T>(item)
        {
            Next = _head
        };
        _head = newHead;
        _count++;
    }

    public void Clear()
    {
        if (_head is null) return;
        GetNodes().ToList().Select(n => n.Next = null);
        _head.Next = null;
        _count = 0;
    }

    public bool Contains(T? item) => GetNodes().Any(node => node.Value is not null && node.Value.Equals(item));

    public void CopyTo(T?[] array, int arrayIndex)
    {
        if (arrayIndex + _count >= array.Length || arrayIndex >= array.Length) throw new IndexOutOfRangeException();
        foreach (var node in GetNodes())
        {
            array[arrayIndex] = node.Value;
            arrayIndex++;
        }
    }

    public IEnumerator<T?> GetEnumerator()
    {
        var nodes = GetNodes().Select(n => n.Value).ToArray();
        return new MyEnumerator<T?>(nodes);
    }

    public bool Remove(T? item)
    {
        if (_head is null) throw new InvalidOperationException();
        MyNode<T?>? preNode = null;
        foreach (var node in GetNodes())
        {
            if (node.Value is not null && node.Value.Equals(item))
            {
                if (preNode is not null) preNode.Next = node.Next;
                else _head = node.Next;
                _count--;
                return true;
            }
            preNode = node;
        }
        return false;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    private IEnumerable<MyNode<T?>> GetNodes()
    {
        var nodes = new MyNode<T?>[_count];
        var index = 0;
        if (_head is null) return nodes;
        var temp = _head;
        nodes[index] = temp;
        while (temp.Next is not null)
        {
            index++;
            temp = temp.Next;
            nodes[index] = temp;
        }
        return nodes;
    }
}
