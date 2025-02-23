using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Jednoduchá kalkulačka v C#");
        Console.Write("Zadej první číslo: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Zadej operátor (+, -, *, /): ");
        char oper = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Zadej druhé číslo: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool validOperation = true;

        switch (oper)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Chyba: Dělení nulou není možné.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Neplatný operátor!");
                validOperation = false;
                break;
        }

        if (validOperation)
            Console.WriteLine($"Výsledek: {num1} {oper} {num2} = {result}");

        Console.WriteLine("Stiskni libovolnou klávesu pro ukončení...");
        Console.ReadKey();
    }
}
