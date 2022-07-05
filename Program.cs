using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1DeQuirozMarcelaPaola
{
    class Program
    {
        static void Main(string[] args)
        {
			double dolares;
			double euros;
			int pesos;

			Console.Write("Ingrese la cantidad de pesos disponibles");
			pesos = int.Parse(Console.ReadLine());

			dolares = pesos / 230;
			euros = dolares / 1.17;

			Console.WriteLine($"Podrá comprar {dolares} dolares");

			

			Console.WriteLine($"Podrá comprar el equivalente  {euros} en euros");
			Console.ReadLine();
		}
	}
}
