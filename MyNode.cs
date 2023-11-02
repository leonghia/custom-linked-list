public class MyNode<T>
{
    public T? Value { get; set; }
    public MyNode<T?>? Next { get; set; }

    public MyNode(T? value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"MyNode[Value=${Value}]";
    }
}
