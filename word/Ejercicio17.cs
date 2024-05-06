/*
Crear un programa en C# que genere e imprima los primeros 15 números
primos gemelos, solicitando al usuario el límite superior del rango
y mostrando los números encontrados.
*/
using System;

class Ejercicio17
{
  /*
  Escribir un programa en C# que calcule e imprima el número de cifras de
  primos gemelos, solicitando al usuario el límite superior del rango y
  mostrando los números encontrados.
  */
  static void x()
  {
    int limite = getPositivo("Ingresa el limite de busqueda: ");
    imprimir(limite);
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

  static bool esPrimo(int n)
  {
    if (n == 1 || n == 0) return false;
    for (int i = 2; i < n; i++)
    {
      if (n % i == 0) return false;
    }
    return true;
  }
  static void imprimir(int limite)
  {
    int count = 0;
    int[] primoslimite = primos(limite);
    int[,] gemelos = getGemelos(primoslimite);
    for (int i = 0; i < gemelos.GetLength(0); i++)
    {
      if (count == 15) break;
      if (gemelos[i, 0] != 0)
      {
        count++;
        Console.WriteLine(count + "  [ " + gemelos[i, 0] + " , " + gemelos[i, 1] + " ]");
      }

    }
  }

  static int[] primos(int limite)
  {
    // hallar los primeros 10 primos
    int i = 0;
    int contador = 0;
    int[] primos = new int[limite];
    while (i != limite)
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

  static int[,] getGemelos(int[] primos)
  {
    int[,] gemelos = new int[primos.Length, 2];
    for (int i = 0; i < primos.Length - 1; i++)
    {

      // primos
      // 3 5 7 9 11 13 15 17 19 21 23 25 27 29 31d -> i = 9 -> i = 10
      if (primos[i + 1] - primos[i] == 2)
      {
        gemelos[i, 0] = primos[i];
        gemelos[i, 1] = primos[i + 1];
      }
      else
      {
        gemelos[i, 0] = 0;
        gemelos[i, 1] = 0;
      }
    }
    return gemelos;
  }

}