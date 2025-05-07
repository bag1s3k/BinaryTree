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

public class BinarySearchTree {
    public Node Root;

    public BinarySearchTree() => Root = null;

    public void Add(int value) => Root = AddRecursive(Root, value);

    private Node AddRecursive(Node current, int value) {
        if (current == null)
            return new Node(value);

        if (value < current.Value)
            current.Left = AddRecursive(current.Left, value);

        if (value > current.Value)
            current.Right = AddRecursive(current.Right, value);
        
        return current;
    }
}

public static class OrderMe {
    public static void InOrder(Node node) {
        if (node != null) {
            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }
    }

    public static void PreOrder(Node node) {
        if (node != null) {
            Console.Write(node.Value + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
    }

    public static void PostOrder(Node node) {
        if (node != null) {
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value + " ");
        }
    }
}

class Program {
    static void Main(string[] args) {
        BinarySearchTree tree = new BinarySearchTree();

        Random rnd = new Random();
        for (int i = 0; i < 1000; i++)
            tree.Add(rnd.Next(1000));

        Stopwatch stopwatch = new Stopwatch();
        
        stopwatch.Start();
        Console.WriteLine("In-order traversal:");
        OrderMe.InOrder(tree.Root);
        stopwatch.Stop();
        Console.WriteLine($">> {stopwatch.Elapsed.TotalMilliseconds}ms");
        
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
    }
}