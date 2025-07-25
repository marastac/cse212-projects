using System;
using System.Collections.Generic;

public class CustomerService
{
    private class Customer
    {
        public string Name { get; }
        public string AccountId { get; }
        public string Problem { get; }

        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        public override string ToString()
        {
            return $"{Name} ({AccountId}) - {Problem}";
        }
    }

    private int _maxSize;
    private List<Customer> _queue;

    public CustomerService(int size)
    {
        _maxSize = size > 0 ? size : 10;
        _queue = new List<Customer>();
    }

    private void AddNewCustomer(string name, string accountId, string problem)
    {
        if (_queue.Count >= _maxSize)
        {
            Console.WriteLine("Maximum number of customers in queue.");
            return;
        }

        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    private void ServeCustomer()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("No customers in queue.");
            return;
        }

        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine("Serving: " + customer);
    }

    public void TestAddCustomer(string name, string accountId, string problem)
    {
        Console.WriteLine($"Trying to add {name}...");
        AddNewCustomer(name, accountId, problem);
    }

    public void TestServeCustomer()
    {
        Console.WriteLine("Trying to serve a customer...");
        ServeCustomer();
    }

    public static void Run()
    {
        Console.WriteLine("Test 1: Enqueue and serve in order");

        var cs = new CustomerService(2);
        Console.WriteLine(cs);

        cs.TestAddCustomer("Ana", "A01", "Password issue");
        cs.TestAddCustomer("Luis", "A02", "Login not working");

        Console.WriteLine(cs);

        cs.TestServeCustomer();
        cs.TestServeCustomer();
        cs.TestServeCustomer(); // Should show "No customers in queue."

        Console.WriteLine("===================");

        Console.WriteLine("Test 2: Try to exceed max queue size");

        var cs2 = new CustomerService(1);
        cs2.TestAddCustomer("Carlos", "A03", "Payment error");
        cs2.TestAddCustomer("Maria", "A04", "Blank page"); // Should be rejected

        Console.WriteLine(cs2);

        Console.WriteLine("===================");
    }

    public override string ToString()
    {
        if (_queue.Count == 0)
        {
            return "Queue is empty.";
        }

        string result = "Queue:\n";
        foreach (Customer customer in _queue)
        {
            result += "- " + customer + "\n";
        }
        return result;
    }
}
