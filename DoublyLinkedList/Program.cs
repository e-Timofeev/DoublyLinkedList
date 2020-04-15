using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> linkedList = new DoubleLinkedList<int>();
            // добавление элементов
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddLast(9);
            linkedList.AddLast(8);
            // содержимое списка
            foreach (var item in linkedList)
            {
                Console.Write(item.ToString() + " ");
            }
            // реверс
            Console.WriteLine();
            linkedList.Reverse();
            foreach (var item in linkedList)
            {
                Console.Write(item.ToString() + " ");
            }
            //
            DoubleLinkedList<string> linkedList2 = new DoubleLinkedList<string>();
            linkedList2.AddFirst("'Первый'");
            linkedList2.AddFirst("'Нет я первый'");
            linkedList2.AddLast("'Второй с конца'");
            linkedList2.AddLast("'Во истину в конце'");
            Console.WriteLine();
            foreach (var item in linkedList2)
            {
                Console.Write(item.ToString() + " ");
            }
            linkedList2.Reverse();
            Console.WriteLine();
            foreach (var item in linkedList2)
            {
                Console.Write(item.ToString() + " ");
            }
            //
            Console.ReadLine();
        }
    }
}
