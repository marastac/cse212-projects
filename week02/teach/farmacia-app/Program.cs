using System;
using System.Collections.Generic;

public class Customer
{
    public string Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

public class Pharmacy
{
    private Queue<Customer> customerQueue = new Queue<Customer>();
    private Stack<string> medicineHistory = new Stack<string>();

    public void AddCustomer(string name)
    {
        Console.WriteLine($"🧾 {name} has entered the pharmacy.");
        customerQueue.Enqueue(new Customer(name));
    }

    public void ServeCustomer(string medicine)
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("❌ No customers in line.");
            return;
        }

        Customer current = customerQueue.Dequeue();
        Console.WriteLine($"💊 Serving {current.Name} with: {medicine}");
        medicineHistory.Push(medicine);
    }

    public void ShowHistory()
    {
        Console.WriteLine("📦 Medicine History (Stack - Last given on top):");
        foreach (var med in medicineHistory)
        {
            Console.WriteLine("- " + med);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pharmacy pharmacy = new Pharmacy();

        pharmacy.AddCustomer("Lucía");
        pharmacy.AddCustomer("Carlos");
        pharmacy.ServeCustomer("Paracetamol");
        pharmacy.ServeCustomer("Ibuprofeno");
        pharmacy.ServeCustomer("Aspirina"); // Nadie en cola

        Console.WriteLine();
        pharmacy.ShowHistory();
    }
}
