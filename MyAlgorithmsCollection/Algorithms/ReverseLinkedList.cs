namespace MyAlgorithmsCollection.Algorithms
{
    public class ReverseLinkedList
    {
        public static Node Reverselist(Node nodo)
        {
            var current = nodo;
            Node prev = null;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }

    // Clase para almacenar nodos
    public class Node
    {
        public Node Next;
        public int Data;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
