using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age;

        // Validate input
        if (int.TryParse(Console.ReadLine(), out age))
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid input. Age cannot be negative.");
            }
            else
            {
                int ticketPrice;

                if (age <= 12 || age >= 65)
                    ticketPrice = 7;  // Discounted price
                else
                    ticketPrice = 10; // Regular price

                Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
