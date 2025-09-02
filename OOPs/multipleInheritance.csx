interface IA
{
    void MethodA();
}

interface IB
{
    void MethodB();
}

class MyClass : IA, IB
{
    public void MethodA()
    {
        Console.WriteLine("MethodA implementationclear");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB implementation");
    }
}

// Usage
MyClass obj = new MyClass();
obj.MethodA(); // Output: MethodA implementation
obj.MethodB(); // Output: MethodB implementation
