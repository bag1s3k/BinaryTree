namespace BinaryTree;

using System.Diagnostics;
using System;
using System.Collections.Generic;

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

        HeapTreeMin htm = new HeapTreeMin();
        
        htm.Add(3);
        htm.Add(9);
        htm.Add(11);
        htm.Add(10);
        htm.Add(12);
        htm.Add(20);
        htm.Add(30);
        htm.Add(16);
        htm.Add(40);
        htm.Add(7);
        Console.WriteLine(htm);
        
        htm.Delete(7);

        Console.WriteLine(htm);
        
        // FillTree(tree, 100000);
        
        /*
        tree.Add(6);
        tree.Add(1);
        tree.Add(7);
        tree.Add(15);
        tree.Add(-5);
        tree.Add(69);
        */

        Stopwatch stopwatch = new Stopwatch();
        
        /*
        stopwatch.Start();
        Console.WriteLine((tree.Search(69)) ? "Found" : "Not found");
        stopwatch.Stop();
        Console.WriteLine($">> {stopwatch.Elapsed.TotalMilliseconds} ms");
        */
        
        /*
        stopwatch.Start();
        Console.WriteLine("In-order traversal:");
        OrderMe.InOrder(tree.Root);
        stopwatch.Stop();
        Console.WriteLine($">> {stopwatch.Elapsed.TotalMilliseconds}ms");
        
        tree.Delete(15);
        
        stopwatch.Restart();
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

    private static void FillTree(BinarySearchTree tree, int length) {
        Random rnd = new Random();
        int rndN = 10000000;
        for (int i = 0; i < rndN; i++)
            tree.Add(rnd.Next(rndN));
    }
}
