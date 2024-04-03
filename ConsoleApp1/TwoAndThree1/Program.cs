using System;

class Worker
{
    public string name { get; set; }
    public string surname { get; set; }
    public int rate { get; set; }
    public int days { get; set; }
    public Worker(string Name, string Surname, int Rate, int Days)
    {
        name = Name; 
        surname = Surname;
        rate = Rate;
        days = Days;
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