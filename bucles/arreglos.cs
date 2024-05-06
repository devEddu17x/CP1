using System;
class Arreglo
{
  /*
  Desarrollar un programa en C# que solicite al usuario un número
  y luego imprima todos los números primos menores que ese número,
  utilizando el algoritmo de la criba de Eratóstenes y
  mostrando los números primos encontrados.

  */
  static void x()
  {
    Console.Write("Ingresa un numero: ");
    string input = Console.ReadLine();
    int n = int.Parse(input);
    int[] tabla = new int[100];
    for (int i = 0; i < 100; i++)
    {
      tabla[i] = n * i;
    }

    for (int i = 0; i < 100; i++)
    {
      Console.WriteLine(tabla[i]);
    }
  }

}