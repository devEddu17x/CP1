using System;

class Ejercicio20
{
  /*

  Desarrollar un programa en C# que solicite al usuario un número y luego
  imprima si es un número perfecto o no, mostrando todos sus divisores y
  validando que el número ingresado sea un número entero no negativo.
  */
  static void x()
  {
    // introducir dos números por teclado.
    int n = getPositivo("Ingrese un numero entero positivo: ");
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
    int suma = 0;
    int mitad = ((int)numero / 2) + 1;

    Console.WriteLine("Divisores de:" + numero);
    for (int i = 1; i <= mitad; i++)
    {
      if (numero % i == 0)
      {
        Console.WriteLine(i);
        suma += i;
      }
    }
    Console.WriteLine("Suma de divisores:" + suma);
    if (suma == numero)
    {
      Console.WriteLine("Es perfecto");
    }
    else
    {
      Console.WriteLine("No es perfecto");
    }
  }


}