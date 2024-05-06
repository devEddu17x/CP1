using System;
class Ejercicio02
{
  /*
  Escribir un programa en C# que calcule e imprima el factorial 
  de un número ingresado por el usuario, utilizando recursión y validando
  que el número ingresado sea un número entero no negativo.

  */
  static void E2()
  {
    int input = getPositivo("Ingresa un numero entero positivo:");
    Console.WriteLine("El facotorial es: " + factorial(input));
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

  static int factorial(int n)
  {
    if (n == 1)
    {
      return n;
    }
    return n * factorial(n - 1);

    // return (n == 1) ? n : n * factorial(n - 1);
  }
}