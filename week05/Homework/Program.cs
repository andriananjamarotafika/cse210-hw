using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        List<int> uniqueList = Enumerable.Range(0, 11)
                                .OrderBy(x => Guid.NewGuid())
                                .Take(11)
                                .ToList();

Console.WriteLine(string.Join(", ", uniqueList));
    }
}