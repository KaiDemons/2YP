using System;

class Worker
{
    private string name;
    private string surname;
    private int rate;
    private int days;

    public Worker(string name, string surname, int rate, int days)
    {
        this.name = name;
        this.surname = surname;
        this.rate = rate;
        this.days = days;
    }
    public string Name
    {
        get { return name; }
    }

    public string Surname
    {
        get { return surname; }
    }

    public int Rate
    {
        get { return rate; }
    }

    public int Days
    {
        get { return days; }
    }

    public void GetSalary()
    {
        int salary = rate * days;
        Console.WriteLine($"Salary of {surname} {name} is {salary}");
    }
}

class Program
{
    static void Main()
    {
        Worker worker1 = new Worker("Aleksandr", "Proskurenko", 10000, 15);
        Worker worker2 = new Worker("Kot", "Miyka", 20000, 10);
        
        worker1.GetSalary();
        worker2.GetSalary();
    }
}
