using System;

class MyClass
{
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    public MyClass(int prop1, string prop2)
    {
        Property1 = prop1;
        Property2 = prop2;
    }

    public MyClass()
    {
        Property1 = 2;
        Property2 = "default";
    }

    ~MyClass()
    {
        Console.WriteLine("Object is deleted");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(624, "Hello");
        Console.WriteLine($"Property1: {obj1.Property1}, Property2: {obj1.Property2}");

        MyClass obj2 = new MyClass();
        Console.WriteLine($"Property1: {obj2.Property1}, Property2: {obj2.Property2}");

        obj1 = null;
        obj2 = null;
        GC.Collect();
    }
}