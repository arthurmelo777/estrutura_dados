interface INode<T> {
    public abstract void SetValue (T Value);
    public abstract T GetValue ();
    public abstract void SetParent (INode<T> Node);
    public abstract INode<T> GetParent ();
    public abstract void SetLeft (INode<T> Node);
    public abstract INode<T> GetLeft ();
    public abstract void SetRight (INode<T> Node);
    public abstract INode<T> GetRight ();
}

interface ITree<T> {
    public abstract int size ();
    public abstract bool isEmpty ();
    public abstract INode<T> root ();
    public abstract bool isInternal (INode<T> Node);
    public abstract bool isExternal (INode<T> Node);
    public abstract int depth (INode<T> Node);
    public abstract int height (INode<T> Node);
}