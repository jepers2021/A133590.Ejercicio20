using System;

namespace A133590.Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 20");
            Console.WriteLine("Dados dos números, presenta el máximo");
            double primerNumero, segundoNumero;

            Console.Write("Por favor ingrese un número: ");
            bool exito = Double.TryParse(Console.ReadLine(), out primerNumero);
            if (!exito)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como numérico.");
                return;
            }

            Console.Write("Por favor ingrese otro número: ");
            exito = Double.TryParse(Console.ReadLine(), out segundoNumero);
            if (!exito)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como numérico.");
                return;
            }

            Console.WriteLine($"Máximo entre los dos números: {Math.Max(primerNumero,segundoNumero)}");

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
