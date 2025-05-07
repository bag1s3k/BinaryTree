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

public abstract class TreeBase {
    public Node Root;
    
    public bool Search(int value) {
        return SearchRecursive(Root, value);
    }

    private bool SearchRecursive(Node node, int value) {
        if (node == null)
            return false;

        if (node.Value == value)
            return true;

        return SearchRecursive(node.Left, value) || SearchRecursive(node.Right, value);
    }
}

public class BinarySearchTree : TreeBase {
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

public class HeapTree {
    
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
