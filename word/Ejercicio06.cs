using System;
class Ejercicio06
{
  /*
  Escribir un programa en C# que calcule e imprima el número de Fibonacci
  correspondiente a una posición ingresada por el usuario, validando que
  la posición ingresada sea un número entero no negativo y mostrando
  el número de forma recursiva.

  */
  static void x()
  {
    int posicion = getPositivo("Ingresa la posicion para el numero de fibonacci: ");
    imprimir(0, posicion);
  }

  static int getPositivo(string mensaje)
  {
    int n;
    Console.Write(mensaje);
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
      Console.Write(mensaje);
    }
    return n;
  }

  static void imprimir(int n, int posicion)
  {
    if (n == posicion) return;
    Console.WriteLine($"Posicion {n + 1}: " + fibonacci(n));
    imprimir(n + 1, posicion);
  }

  static int fibonacci(int n)
  {

    if (n == 0) return 0;
    if (n == 1) return 1;

    return fibonacci(n - 1) + fibonacci(n - 2);
  }
}
