using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pilas001
{

 
        class Pila
        {
            private int[] elemento = new int[20];
            private int tope;

            public Pila()
            {
                for (int i = 0; i < 20; i++)
                {
                    elemento[i] = 0;
                    tope = -1;
                }
            }
            public void ImprimirPila()
            {

                for (int i = 0; i <= tope; i++)
                {
                    Console.WriteLine(elemento[i]);
                }
                Console.WriteLine("Esto es todo!");
            }
            public void Push(int a)
            {
                elemento[tope + 1] = a;
                tope += 1;
            }
            public int Pop()
            {
                int auxiliar;
                auxiliar = elemento[tope];
                elemento[tope] = 0;
                tope -= 1;
                return auxiliar;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Pila Mi_Pila = new Pila();
            Mi_Pila.Push(10);
            Mi_Pila.ImprimirPila();
        }
    }
}
