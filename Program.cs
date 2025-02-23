using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Jednoduchá kalkulačka v C#");
        Console.Write("Zadej první číslo: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Zadej operátor (+, -, *, /, ^, r): ");
        char oper = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double num2 = 0;
        if (oper != 'r')
        {
            Console.Write("Zadej druhé číslo: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }

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
            case '^':
                result = Math.Pow(num1, 2);
                break;
            case 'r':
                if (num1 >= 0)
                    result = Math.Sqrt(num1);
                else
                {
                    Console.WriteLine("Chyba: Odmocnina záporného čísla není možná.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Neplatný operátor!");
                validOperation = false;
                break;
        }

        if (validOperation)
            Console.WriteLine($"Výsledek: {result}");

        Console.WriteLine("Stiskni libovolnou klávesu pro ukončení...");
        Console.ReadKey();
    }
}
