using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite qual das seguindes formas geométricas você deseja calcular a área");
            Console.WriteLine("1-Quadrado");
            Console.WriteLine("2-retangulo");
            Console.WriteLine("3-trapézio");
            Console.WriteLine("4-losango");
            Console.Write("Escolha: ");
            int esc = int.Parse(Console.ReadLine());

            switch (esc)
            {
                case 1: 
                    areaquadrado();
                    break;

                case 2:
                    arearetangulo();
                    break;

                case 3:
                    areatrapezio();
                    break;

                case 4:
                    arealosango();
                    break;  
            }
            Console.ReadKey();
        }

        static void areaquadrado()
        {
            Console.Write("Digite o lado do quadrado: ");
            double l = double.Parse(Console.ReadLine());

            double a = l * l;

            Console.WriteLine("A área do quadrado é: " + a);
        }
        static void arearetangulo()
        {
            Console.Write("Digite o primeiro lado do retangulo: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo lado do retangulo: ");
            double l2 = double.Parse(Console.ReadLine());

            double a = (l * l2);

            Console.WriteLine("A área do retangulo é: " + a);
        }
        static void areatrapezio()
        {
            Console.Write("Digite o comprimento maior do retangulo: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento menor do retangulo: ");
            double l2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do retangulo: ");
            double h = double.Parse(Console.ReadLine());

            double a = (l + l2)*h/2;

            Console.WriteLine("A área do trapézio é: " + a);
        }
        static void arealosango()
        {
            Console.Write("Digite a diagonal maior do retangulo: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Digite a diagonal menor do retangulo: ");
            double l2 = double.Parse(Console.ReadLine());
            

            double a = (l * l2) / 2;

            Console.WriteLine("A área do losango é: " + a);
        }
    }
}
