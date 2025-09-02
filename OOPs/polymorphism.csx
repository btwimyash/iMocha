using System;
using System.Collections.Generic;

// Base class
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class 1
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Derived class 2
public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

// Usage
var animals = new List<Animal>
{
    new Dog(),
    new Cat(),
    new Animal()
};

foreach (var animal in animals)
{
    animal.Speak();
}
