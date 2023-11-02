public interface IMyLinkedList<T> : ICollection<T>
{
    void AddToFront(T item);
    void AddToEnd(T item);
}
