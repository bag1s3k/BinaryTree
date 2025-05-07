namespace BinaryTree;

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