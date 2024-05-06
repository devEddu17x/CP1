using System;
class Ejercicio08
{
  /*
  Crear un programa en C# que genere e imprima los primeros 25 números
  primos de la serie de Lucas, permitiendo al usuario especificar el
  punto de inicio de la serie y mostrando los números primos encontrados.

  */
  static void x()
  {
    // introducir dos números por teclado.
    int numero = getPositivo("Introduce el punto de inicio de la serie: ");
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
    Console.WriteLine("Numeros primos entre los 25 numeros de Lucas a partir de la posicion: " + numero);
    int[] arreglo = lucas(numero);
    for (int i = 0; i < arreglo.Length; i++)
    {
      if (i + 1 <= numero) continue;
      if (esPrimo(arreglo[i]))
      {
        Console.WriteLine(arreglo[i]);
      }
    }
  }

  static int[] lucas(int n)
  {
    int[] arreglo = new int[n + 25];
    int primero = 2, segundo = 1;
    for (int i = 0; i < n + 25; i++)
    {
      if (i == 0)
      {
        arreglo[i] = primero;
        continue;
      }
      if (i == 1)
      {
        arreglo[i] = segundo;
        continue;
      }

      arreglo[i] = arreglo[i - 1] + arreglo[i - 2];
    }

    return arreglo;
  }

  static bool esPrimo(int n)
  {
    if (n == 1) return false;
    for (int i = 2; i < n; i++)
    {
      if (n % i == 0) return false;
    }
    return true;
  }


}