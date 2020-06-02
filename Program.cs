using System;

namespace horasistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data e hora atual do sistema");
            DateTime horasistema = DateTime.Now;
            Console.WriteLine($"hora sistema:{horasistema}");
        }
    }
}
