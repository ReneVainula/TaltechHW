// Task 1: Implementation of a Binary Tree

class Node
{
    public int Value;
    public Node Left;
    public Node Right;
}

class Tree
{
    public Node Insert(Node root, int v) {
        if (root == null) {
            root = new Node();
            root.Value = v;
        }
        else if (v < root.Value) {
            root.Left = Insert(root.Left, v);
        }
        else {
            root.Right = Insert(root.Right, v);
        }

        return root;
    }
}
