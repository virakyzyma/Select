using System;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int PhoneNumber { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[]
        {
            new Person { Name = "Joe", Age = 20, PhoneNumber = 11111, Country = "Ukraine", Email = "joe@gmail.com" },
            new Person { Name = "Anna", Age = 21, PhoneNumber = 22222, Country = "Ukraine", Email = "anna@gmail.com" },
            new Person { Name = "Alan", Age = 22, PhoneNumber = 33333, Country = "Ukraine", Email = "alan@gmail.com" }
        };
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Phone Number: {person.PhoneNumber}, Address: {person.Country}, Email: {person.Email}");
        }

        var selectedProperties = people.Select(person => new { person.Name, person.Age }).ToArray();

        foreach (var prop in selectedProperties)
        {
            Console.WriteLine($"Name: {prop.Name}, Age: {prop.Age}");
        }
    }
}
