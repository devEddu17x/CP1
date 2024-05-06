using System;
using System.Diagnostics;
using System.Reflection;
class Ejercicio12
{
  /*

  Desarrollar un programa en C# que solicite al usuario un número y
  luego imprima si es un número triangular o no, mostrando la secuencia
  de números triangulares hasta ese punto y verificando si el número es triangular.

  */
  static void x()
  {
    // introducir dos números por teclado.
    int n = getPositivo("Ingresa un entero positivo: ");
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
    int triangulo = 1;
    int contadodr = 1;
    while (true)
    {
      triangulo = (contadodr * (contadodr + 1)) / 2;
      Console.WriteLine("( " + contadodr + " * (" + contadodr + " + 1 ) )/ 2  = " + triangulo);
      if (triangulo > numero)
      {
        Console.WriteLine("No es un numero triangulo");
        break;
      }
      if (triangulo == numero)
      {
        Console.WriteLine("Es un numero triangulo");
        break;
      }
      contadodr++;
    }
  }
}