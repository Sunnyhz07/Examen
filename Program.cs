

using System;


     class Program
    {

    static void Main(string[] args) {

        //Luis Salvador Olin A
        //Zuny Paola Hernandez Valenzuela

        //1.

        int x;
        Console.WriteLine("Ingrese el número: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine($"El cuadrado del número: {x * x}");
        Console.ReadKey();


        //2.
        float y = 0;
        Console.WriteLine("Ingrese el número:");
        y = float.Parse(Console.ReadLine());
        Console.WriteLine($"El primer resultado es: {-6 + y * 10}");
        Console.WriteLine($"El segundo resultado es: {(15 - 2) * y}");
        Console.WriteLine($"El tercer resultado es: {(y - 2) * (35 / 10)}");
        Console.WriteLine($"El cuarto resultado es: {(13 + y) / (45 - 4)}");


        //3.

        int z, a, b;
        Console.WriteLine("Introduzca el primer valor entero");
        z = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo valor entero");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el tercer valor entero");
        b = int.Parse(Console.ReadLine());

        
    }
}