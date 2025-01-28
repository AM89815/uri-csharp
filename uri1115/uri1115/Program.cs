using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int X, Y;
        String[] var = Console.ReadLine().Split(' ');
        X = int.Parse(var[0], CultureInfo.InvariantCulture);
        Y = int.Parse(var[1], CultureInfo.InvariantCulture);

        while (X != 0 && Y != 0)
        {
            if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("primeiro");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("segundo");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("terceiro");
            }
            else if (X > 0.0 && Y < 0.0)
            {
                Console.WriteLine("quarto");
            }
            var = Console.ReadLine().Split(' ');
            X = int.Parse(var[0], CultureInfo.InvariantCulture);
            Y = int.Parse(var[1], CultureInfo.InvariantCulture);
        }
    }
}