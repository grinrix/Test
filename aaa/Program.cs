using System;

class Kalkulator
{
    static void ShowMenu()
    {
        Console.WriteLine("\nKalkulator");
        Console.WriteLine("-----------------");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnozenie");
        Console.WriteLine("4. Dzielenie");
        Console.WriteLine("5. Wyjscie");
        Console.Write("Wybierz operacje (1-5): ");
    }

    static void Main(string[] args)
    {
        int choice;
        double num1 = 0, num2 = 0, result; // Zainicjalizowanie zmiennych num1 i num2

        do
        {
            ShowMenu();
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Nieprawidlowy wybor. Sprobuj ponownie.");
                continue;
            }

            if (choice >= 1 && choice <= 4)
            {
                Console.Write("Podaj pierwsza liczbe: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Nieprawidlowa liczba. Sprobuj ponownie: ");
                }

                Console.Write("Podaj druga liczbe: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Nieprawidlowa liczba. Sprobuj ponownie: ");
                }
            }

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Wynik: {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Wynik: {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Wynik: {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Wynik: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Blad: Dzielenie przez zero!");
                    }
                    break;
                case 5:
                    Console.WriteLine("Koniec programu. Do widzenia!");
                    break;
                default:
                    Console.WriteLine("Nieprawidlowy wybor. Sprobuj ponownie.");
                    break;
            }

        } while (choice != 5);
    }
}
