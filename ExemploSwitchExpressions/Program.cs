using System;

namespace ExemploSwitchExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Área de um quadrado de lado 4: " +
                Area.Calcular(FiguraGeometrica.Quadrado, 4));
            Console.WriteLine("Área de um retângulo de 5 x 6: " +
                Area.Calcular(FiguraGeometrica.Retangulo, 5, 6));
            Console.WriteLine("Área de um triângulo de base 7 e altura 8: " +
                Area.Calcular(FiguraGeometrica.Triangulo, 7, 8));
        }
    }
}