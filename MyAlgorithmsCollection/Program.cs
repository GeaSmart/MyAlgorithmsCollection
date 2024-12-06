using AlgorithmsBook.Algorithms;
using MyAlgorithmsCollection.Algorithms;
using System;

namespace AlgorithmsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear lista enlazada 1 -> 2 -> 3 -> 4 -> 5
            Node mi_nodo = new Node(1);
            mi_nodo.Next = new Node(2);
            mi_nodo.Next.Next = new Node(3);
            mi_nodo.Next.Next.Next = new Node(4);
            mi_nodo.Next.Next.Next.Next = new Node(5);

            // Invierto la lista enlazada
            mi_nodo = ReverseLinkedList.Reverselist(mi_nodo);

            // Imprimir
            while (mi_nodo != null)
            {
                Console.WriteLine(mi_nodo.Data);
                mi_nodo = mi_nodo.Next;
            }
            Console.WriteLine();
        }
    }
}
