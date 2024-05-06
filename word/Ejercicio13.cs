using System;
using System.Diagnostics;
using System.Reflection;
class Ejercicio13
{
  /*

  Crear un programa en C# que genere e imprima los primeros 10
  números primos de Mersenne y sus correspondientes números perfectos,
  solicitando al usuario cuántos desea ver y mostrando los números encontrados.

  */
  static void x()
  {
    // introducir dos números por teclado.
    int n = getPositivo("Cuantos numeros de Mersene y su correspondiente numero perfecto desea ver: ");
    imprimir(n);

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

    int[] primosArreglo = primos(numero);
    for (int i = 0; i < numero; i++)
    {
      long numeroMersene = mersene(primosArreglo[i]);
      long numeroPerfecto = perfecto(numeroMersene, primosArreglo[i]);
      Console.WriteLine("Numero de Mersene: " + numeroMersene + " y numero perfecto: " + numeroPerfecto);
    }
  }

  static int[] primos(int n)
  {
    // hallar los primeros 10 primos
    int i = 0;
    int contador = 0;
    int[] primos = new int[n];
    while (contador < n)
    {
      if (esPrimo(i))
      {
        primos[contador] = i;
        contador++;
      }
      i++;
    }
    return primos;
  }

  static bool esPrimo(int n)
  {
    if (n == 1 || n == 0) return false;
    for (int i = 2; i < n; i++)
    {
      if (n % i == 0) return false;

    }
    return true;
  }

  static int mersene(int primo)
  {
    return (int)Math.Pow(2, primo - 1);
  }

  static long perfecto(long mersene, int primo)
  {
    return mersene * (long)(Math.Pow(2, primo) - 1);
  }
}