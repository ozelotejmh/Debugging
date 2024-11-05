using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numeros = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12,13,14,15};  // Cambiar a new List<int> { 1, 2, 3 } para probar
                int suma = SumarNumeros(numeros);
                int sumapares = SumarPares(numeros);
                int sumarandom = SumarRandoms(numeros);
                //Console.WriteLine("La suma es: " + suma);
                //Console.WriteLine("La suma pares es: " + sumapares);
                Console.WriteLine("La suma random es: " + sumarandom);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static int SumarNumeros(List<int> numeros)
        {
            if (numeros == null)
                throw new ArgumentNullException(nameof(numeros), "La lista de números no puede ser nula.");

            int total = 0;
            foreach (var numero in numeros)
            {
                // 0
                // 1
                // 3
                // 6
                // 10
                // 15
                // 21
                // 28
                // 36
                // 45
                // 55
                // 67
                // 80
                // 94
                // 109

                total += numero;
            }
            return total;
        }

        static int SumarRandoms(List<int> numeros)
        {
            if (numeros == null)
                throw new ArgumentNullException(nameof(numeros), "La lista de números no puede ser nula.");
            if (numeros.Count < 10)
                throw new ArgumentException("La lista debe contener al menos 10 números.");

            Random rnd = new Random();
            int suma = 0;

            // Selecciona y suma 10 números aleatorios de la lista
            for (int i = 0; i < 10; i++)
            {
                // 0
                // 9
                // 19
                // 22
                // 24
                // 32
                // 36
                // 48
                // 62
                // 67
                // 72
                int index = rnd.Next(numeros.Count);
                suma += numeros[index];
            }

            return suma;
        }


        static int SumarPares(List<int> numeros)
        {
            if (numeros == null)
                throw new ArgumentNullException(nameof(numeros), "La lista de números no puede ser nula.");

            int suma = 0;

            // Iteramos sobre la lista para sumar solo los números pares
            foreach (var numero in numeros)
            {
                if (numero % 2 == 0) // Verificamos si el número es par
                {
                    // 0
                    // 2
                    // 6
                    // 12
                    // 20
                    // 30
                    // 42
                    // 56
                    suma += numero;
                }
            }

            return suma;
        }
    }
}
