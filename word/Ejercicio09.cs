using System;
class Ejercicio09
{
  /*
  Desarrollar un programa en C# que solicite al usuario un número
  y luego imprima todos los números primos menores que ese número,
  utilizando el algoritmo de la criba de Eratóstenes y
  mostrando los números primos encontrados.

  */
  static void x()
  {
    // introducir dos números por teclado.
    int numero = getPositivo("Ingresa un entero positivo: ");
    imprimir(numero);

  }
  static int getPositivo(string mensaje)
  {
    int n;
    n = getN(mensaje);
    while (n <= 0)
    {
      n = getN(mensaje);
    }

    return n;
  }
  static int getN(string mensaje)
  {
    Console.Write(mensaje);
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
      Console.Write(mensaje);
    }
    return n;
  }

  static void imprimir(int numero)
  {
    bool[] esPrimo = new bool[numero + 1]; // numero fuera 4 -> [0, 1, 2, 3, 4]

    for (int i = 0; i < esPrimo.Length; i++) // llenar todo de true
    {
      esPrimo[i] = true;
    }

    for (int i = 2; i * i <= numero; i++) // i = 2  -> [0, 1, "2", 3, 4]
    {
      if (esPrimo[i])
      {
        for (int j = i * i; j <= numero; j += i) // j = i * i ; i = 2; j = 4 -> /4 /1 /2 -> no es primo -> divisores >= 3 
        {
          esPrimo[j] = false;
        }
      }
    }

    int count = 2;
    for (int i = 2; i <= numero; i++)
    {
      // [true, true, true, false]
      if (esPrimo[i])
      {
        Console.WriteLine(i + " -> es primo");
      }
      count++;
    }
  }

}