namespace BinaryTree;

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