namespace BinaryTree;

using System;

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