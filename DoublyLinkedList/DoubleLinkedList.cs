using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>, IEnumerable<T>
    {
        protected class Node : INode<T>
        {
            public T Value { get; set; }
            public INode<T> Next { get; set; }
            public INode<T> Prev { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }

        public INode<T> First { get; set; }
        public INode<T> Last { get; set; }
        public int Bufer { get; set; } = 0;

        /// <summary>
        /// добавить в начало списка.
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(T value)
        {
            INode<T> node = new Node(value);
            INode<T> temp = First;
            node.Next = temp;
            First = node;
            if (Bufer == 0) Last = First;
            else temp.Prev = node;
            Bufer++;
        }

        /// <summary>
        /// добавить в конец списка.
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            INode<T> node = new Node(value);
            if (Bufer == 0)
            {
                First = node;
            }
            else
            {
                Last.Next = node;
                node.Prev = Last;
            }
            Last = node;
            Bufer++;
        }

        /// <summary>
        /// Реверс.
        /// </summary>
        public void Reverse()
        {
            if (First == null) return;

            INode<T> prev = null,
            current = First, next = null;

            while (current.Next != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            current.Next = prev;
            First = current;
        }

        /// <summary>
        /// Для перебора в цикле. 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            INode<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
