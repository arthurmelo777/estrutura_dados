using System;

class Node<T> : INode<T> {
    private T value;
    private INode<T> parent;
    private INode<T> leftChild;
    private INode<T> rightChild;

    public void SetValue (T v) {
        value = v;
    }
    public T GetValue () {
        return value;
    }
    public void SetParent (INode<T> n) {
        parent = n;
    }
    public INode<T> GetParent () {
        return parent;
    }
    public void SetLeft (INode<T> n) {
        leftChild = n;
    }
    public INode<T> GetLeft () {
        return leftChild;
    }
    public void SetRight (INode<T> n) {
        rightChild = n;
    }
    public INode<T> GetRight () {
        return rightChild;
    }

    public Node (T v) {
        value = v;
    }
}

class Tree {
    public static void Main (string[] args) {
        Console.WriteLine("Oiee");
    }
}