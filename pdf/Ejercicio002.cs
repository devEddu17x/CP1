using System;
class Ejercicio002
{
  /*
  Elabora un algoritmo que permita leer dos números positivos. Debe validar que el segundo
  número debe ser mayor que el primero. Luego se deben imprimir todos los números primos
  que se encuentren entre ambos números.
  */
  static void e2()
  {
    // introducir dos números positivos por teclado.
    int n1 = getPositivo("Introduce un entero positovo valido N1: ");
    int n2 = getPositivo("Introduce un numero mayor a N1: ");
    // validar n2 > n1
    while (!(n2 > n1))
    {
      n2 = getPositivo("Introduce un numero mayor a N1: ");
    }
    // solucion general del problema
    imprimir(n1, n2);


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

  static void imprimir(int menor, int mayor)
  {
    Console.WriteLine($"Los primos entre {menor} y {mayor} son: ");
    for (int i = menor; i <= mayor; i++)
    {
      if (esPrimo(i))
      {
        Console.WriteLine(i + " es primoo");
      }
    }
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