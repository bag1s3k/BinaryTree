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

    public void Delete(int value) => Root = DeleteRecursive(Root, value);

    private Node DeleteRecursive(Node node, int value) {
        if (node == null)
            return null;

        if (value < node.Value)
            node.Left = DeleteRecursive(node.Left, value);
        else if (value > node.Value)
            node.Right = DeleteRecursive(node.Right, value);
        else {
            if (node.Left == null)
                return node.Right;
            else if (node.Right == null)
                return node.Left;
            
            Node minNode = FindMin(node.Right);
            node.Value = minNode.Value;
            node.Right = DeleteRecursive(node.Right, minNode.Value);
        }


        return node;
    }

    private Node FindMin(Node node) {
        while (node.Left != null)
            node = node.Left;

        return node;
    }
}