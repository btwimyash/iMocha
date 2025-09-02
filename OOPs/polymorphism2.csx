using System;

// Overloaded Add method - different parameter lists
int Add(int a, int b) => a + b;

double Add(double a, double b) => a + b;

int Add(int a, int b, int c) => a + b + c;

// Directly calling methods
Console.WriteLine(Add(5, 10));
Console.WriteLine(Add(5.5, 3.2));
Console.WriteLine(Add(1, 2, 3));

