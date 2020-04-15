namespace DoublyLinkedList
{
    /// <summary>
    /// Двусвязный список
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDoubleLinkedList<T>
    {
        /// <summary>
        /// Первый элемент.
        /// </summary>
        INode<T> First { get; set; }

        /// <summary>
        /// Последний элемент.
        /// </summary>
        INode<T> Last { get; set; }

        /// <summary>
        /// Выводит элементы двусвязного списка в обратном направлении.
        /// </summary>
        void Reverse();

        /// <summary>
        /// Вставляет новый узел с заданным значением в начало списка.
        /// </summary>
        /// <param name="value"></param>
        void AddFirst(T value);

        /// <summary>
        /// Вставляет новый узел с заданным значением в конец списка.
        /// </summary>
        /// <param name="value"></param>
        void AddLast(T value);
    }

    /// <summary>
    /// Узел двусвязного списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface INode<T>
    {
        T Value { get; set; }
        /// <summary>
        /// Ссылка на следующий узел.
        /// </summary>
        INode<T> Next { get; set; }

        /// <summary>
        /// Ссылка на предыдущий узел.
        /// </summary>
        INode<T> Prev { get; set; }
    }
}
