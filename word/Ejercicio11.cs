using System;
using System.Diagnostics;
class Ejercicio11
{
  /*
Implementar un programa en C# que solicite al usuario un número y
luego imprima el producto de los dígitos pares y el producto de los
dígitos impares por separado, validando que el número ingresado sea
positivo y mostrando los productos calculados.

  */
  static void x()
  {
    // introducir dos números por teclado.
    int n = getPositivo("Ingresa un entero positivo: ");
    int[] digitos = getDigitos(n);
    Console.WriteLine("El producto de los digitos pares es: " + productoPares(digitos));
    Console.WriteLine("El producto de los digitos impares es: " + productoImpares(digitos));

  }

  private static int[] getDigitos(int n)
  {
    // sacar los digitos de un numero y pasarlo a un arreglo
    int[] arreglo = new int[n.ToString().Length];
    int i = 0;
    while (n > 0)
    {
      arreglo[i] = n % 10;
      n /= 10;
      i++;
    }

    return arreglo;
  }

  private static int productoPares(int[] n)
  {
    // multiplicar los digitos pares de un arreglo
    int producto = 1;
    for (int i = 0; i < n.Length; i++)
    {
      if (n[i] % 2 == 0)
      {
        producto *= n[i];
      }
    }

    return producto;
  }

  private static int productoImpares(int[] n)
  {
    // multiplicar los digitos impares de un arreglo
    int producto = 1;
    for (int i = 0; i < n.Length; i++)
    {
      if (n[i] % 2 != 0)
      {
        producto *= n[i];
      }
    }

    return producto;

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
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
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

    stopwatch.Stop();
    Console.WriteLine("Tiempo de ejecución: " + stopwatch.ElapsedMilliseconds + " ms");
  }

}