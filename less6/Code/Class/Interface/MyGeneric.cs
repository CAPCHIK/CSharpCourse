class MyGeneric<T, G> : object
{
    private T[] array;
    public T Value {get; set;}

    public void Some(T arg)
    {}

    public void Some<R>(R val)
    {}
}