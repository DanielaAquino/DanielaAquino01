using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "si";
            char buscar;
            int p;
            char[] dato = new char[10];

            while(op=="si")
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opción que desea realizar: \n1. Ingresar valores \n2. Mostrar valores \n3. Buscar valores");
                p = int.Parse(Console.ReadLine());

                if(p==1)
                {
                    Console.Clear();
                    for (int i = 0; i <= 9; i++)
                    {
                        Console.WriteLine("i: "+i);
                        Console.Write("Ingrese una letra:  ");
                        dato[i] = char.Parse(Console.ReadLine());
                    }
                    Console.Write("Presiona enter para volver al menú.  ");
                }

                if (p == 2)
                {
                    Console.Clear();
                    for (int x = 0; x <= 9; x++)
                    {
                        Console.WriteLine(dato[x]);
                    }
                    Console.ReadLine();
                    Console.Write("Presiona enter para volver al menú.  ");
                }

                if (p == 3)
                {
                    Console.Clear();
                    Console.Write("Ingrese caracter a buscar: ");
                    buscar = char.Parse(Console.ReadLine());

                    for (int z = 0; z <= 9; z++)
                    {
                       if (dato[z] ==buscar)
                          {
                           Console.WriteLine("dato: " + buscar + " encontrado");
                          }
                    }
                    Console.Write("Presiona enter para volver al menú.  ");
                }
                Console.ReadKey();
            }
        }
    }
}
