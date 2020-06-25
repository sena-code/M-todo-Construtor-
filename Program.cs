using System;

namespace Método_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Construtor cons1 = new Construtor();
            Console.WriteLine($"Aluma coisa {cons1.Something}, Construir {cons1.Biuld}");
            Construtor cons2 = new Construtor();
            Console.WriteLine($"Aluma coisa {cons2.Something}, Construir {cons2.Biuld}");
            Construtor cons3 = new Construtor();
            Console.WriteLine($"Aluma coisa {cons3.Something}, Construir {cons3.Biuld}");



            
        }
    }
}
