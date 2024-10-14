using System;

public class NoException : Exception {
    public NoException (string msg) : base(msg) { }
}

public class TreeException : Exception {
    public TreeException (string msg) : base(msg) { }
}