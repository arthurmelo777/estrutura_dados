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
        //if (parent == null) throw new NoException("No está vazio");
        return parent;
    }
    public void SetLeft (T v) {
        INode<T> Node = new Node<T>(v);
        leftChild = Node;
    }
    public INode<T> GetLeft () {
        //if (leftChild == null) throw new NoException("No está vazio");
        return leftChild;
    }
    public void SetRight (T v) {
        INode<T> Node = new Node<T>(v);
        rightChild = Node;
    }
    public INode<T> GetRight () {
        //if (rightChild == null) throw new NoException("No está vazio");
        return rightChild;
    }

    public Node (T v) {
        value = v;
        leftChild = null;
        rightChild = null;
    }
}

class Tree<T> : ITree<T>
{
    private int size = 0;
    private INode<T> root;

    public int GetSize () {
        return size;
    }

    public bool isEmpty () {
        if (size == 0) return true;
        else return false;
    }

    public INode<T> GetRoot () {
        if (root == null) throw new TreeException("Arvore vazia");
        return root;
    }

    public bool isInternal (INode<T> Node) {
        if (!isExternal(Node)) return true;
        else return false;
    }

    public bool isExternal (INode<T> Node) {
        if (Node.GetLeft() == null && Node.GetRight() == null) return true;
        else return false;
    }

    public bool isRoot (INode<T> Node) {
        return Node == root;
    }

    public int depth (INode<T> Node) {
        if (isRoot(Node)) return 0;
        else return 1 + depth(Node.GetParent());
    }

    public int height (INode<T> Node) {
        if (isExternal(Node)) return 0;
        else {
            return 1 + Math.Max(height(Node.GetLeft()), height(Node.GetRight()));
        }
    }

    public void addLeft (INode<T> Node, T value) {
        Node.SetLeft(value);
        size++;
    }

    public void addRight (INode<T> Node, T value) {
        Node.SetRight(value);
        size++;
    }

    public Tree (T v) {
        root = new Node<T>(v);
        size++;
    }
}

class Program {
    public static void Main (string[] args) {
        Console.WriteLine("Cria a árvore");
        Tree<int> t = new Tree<int>(6);

        Console.WriteLine("Valor = " + t.GetRoot().GetValue());
        Console.WriteLine("Profundidade = " + t.depth(t.GetRoot()));
        Console.WriteLine("Altura = " + t.height(t.GetRoot()));
        Console.WriteLine("Tamanho = " + t.GetSize());

        Console.WriteLine("Adiciona filho esquerdo");

        Console.WriteLine("Adiciona filho direito");

        Console.WriteLine("Adiciona filho esquerdo no filho esquerdo");
    }
}