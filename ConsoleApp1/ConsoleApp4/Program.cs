using System;

class Counter
{
    private int value;

    public Counter()
    {
        value = 0;
    }

    public Counter(int initialValue)
    {
        value = initialValue;
    }

    public void Increment()
    {
        value++;
    }

    public void Decrement()
    {
        value--;
    }

    public int Value
    {
        get { return value; }
    }
}

class Program
{
    static void Main()
    {
        Counter counter1 = new Counter();
        Console.WriteLine("Counter 1 initial value: " + counter1.Value);
        counter1.Increment();
        Console.WriteLine("Counter 1 after increment: " + counter1.Value);
        counter1.Decrement();
        Console.WriteLine("Counter 1 after decrement: " + counter1.Value);

        Counter counter2 = new Counter(5);
        Console.WriteLine("\nCounter 2 initial value: " + counter2.Value);
        counter2.Increment();
        Console.WriteLine("Counter 2 after increment: " + counter2.Value);
        counter2.Decrement();
        Console.WriteLine("Counter 2 after decrement: " + counter2.Value);
    }
}
