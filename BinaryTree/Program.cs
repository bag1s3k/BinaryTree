namespace BinaryTree;

using System.Diagnostics;
using System;

public class Node {
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value) {
        this.Value = value;
        this.Left = null;
        this.Right = null;
    }
}

class Program {
    static void Main(string[] args) {
        BinarySearchTree tree = new BinarySearchTree();
        
        /*
        Random rnd = new Random();
        int rndN = 10000000;
        for (int i = 0; i < rndN; i++)
            tree.Add(rnd.Next(rndN));
        */
        
        tree.Add(6);
        tree.Add(1);
        tree.Add(7);
        tree.Add(15);
        tree.Add(-5);
        tree.Add(69);

        Stopwatch stopwatch = new Stopwatch();
        
        stopwatch.Start();
        Console.WriteLine((tree.Search(69)) ? "Found" : "Not found");
        stopwatch.Stop();
        Console.WriteLine($">> {stopwatch.Elapsed.TotalMilliseconds} ms");
        
        /*
        stopwatch.Start();
        Console.WriteLine("In-order traversal:");
        OrderMe.InOrder(tree.Root);
        stopwatch.Stop();
        Console.WriteLine($">> {stopwatch.Elapsed.TotalMilliseconds}ms");
        */
        
        /*
        stopwatch.Restart();
        stopwatch.Start();
        Console.WriteLine("\nPre-order traversal: ");
        OrderMe.PreOrder(tree.Root);
        stopwatch.Stop();
        Console.WriteLine($">> {stopwatch.Elapsed.TotalMilliseconds}ms");

        stopwatch.Restart();
        stopwatch.Start();
        Console.WriteLine("\nPost-order traversal: ");
        OrderMe.PostOrder(tree.Root);
        stopwatch.Stop();
        Console.WriteLine($">> {stopwatch.Elapsed.TotalMilliseconds}ms");
        */
    }
}
