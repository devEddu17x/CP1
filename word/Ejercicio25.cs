using System;

class Ejercicio25
{
  /*

  Crear un programa en C# que genere e imprima los primeros 20 números de
  Fibonacci que sean primos, permitiendo al usuario elegir el límite superior
  del rango y mostrando los números encontrados.

  */
  static void x()
  {
    long n = getPositivo("Ingrese el limte superior: ");
    imprimir(n);
  }



  static long getPositivo(string mensaje)
  {
    long n;
    n = getN(mensaje);
    while (n <= 0)
    {
      n = getN(mensaje);
    }

    return n;
  }
  static long getN(string mensaje)
  {
    Console.Write(mensaje);
    long n;
    while (!long.TryParse(Console.ReadLine(), out n))
    {
      Console.Write(mensaje);
    }
    return n;
  }
  static void imprimir(long limite)
  {
    long[] numerosFibonaccis = Fibonacci(limite);
    for (long i = 0; i < numerosFibonaccis.Length; i++)
    {
      if (esPrimo(numerosFibonaccis[i]))
      {
        Console.WriteLine("Es fibonacci y es primo: " + numerosFibonaccis[i]);
      }
    }
  }

  static bool esPrimo(long n)
  {
    if (n == 1 || n == 0) return false;
    for (long i = 2; i < n; i++)
    {
      if (n % i == 0) return false;
    }
    return true;
  }

  static long[] Fibonacci(long limite)
  {
    long[] arreglo = new long[20];
    int contador = 0;
    for (long i = 0; i < limite; i++)
    {
      long n = fibonacci(i);
      if (n > limite || contador == 20)
      {
        Console.WriteLine("Limite superado. Numero fibonacci: " + n + "  Limite: " + limite);
        break;
      }

      if (esPrimo(n))
      {
        arreglo[contador] = n;
        contador++;
      }
    }
    return arreglo;
  }

  static long fibonacci(long n)
  {
    if (n == 0) return 0;
    if (n == 1) return 1;
    return fibonacci(n - 1) + fibonacci(n - 2);
  }
}