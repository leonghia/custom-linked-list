using System.Collections;

public class MyEnumerator<N> : IEnumerator<N>
{
    private const int _startIndex = -1;
    private readonly N[] _list;
    private int _currentIndex = _startIndex;

    public MyEnumerator(N[] list)
    {
        _list = list;
    }

    public N Current => _list[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // Nothing to dispose
    }

    public bool MoveNext()
    {
        if (_currentIndex + 1 >= _list.Length) return false;
        _currentIndex++;
        return true;
    }

    public void Reset()
    {
        _currentIndex = _startIndex;
    }
}
