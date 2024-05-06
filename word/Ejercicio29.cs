using System;
class Ejercicio29
{
  /*
  Escribir un programa en C# que calcule e imprima el máximo común divisor (MCD)
  de dos números ingresados por el usuario, utilizando el algoritmo de Euclides y
  validando que los números ingresados sean enteros no negativos.
  */
  static void Main()
  {
    // introducir dos números por teclado.
    int numero = getPositivo("Introduce un entero positivo: ");
    int numero2 = getPositivo("Introduce otro numero entero positivo: ");
    int mcd;
    if (numero > numero2)
    {
      mcd = euclides(numero, numero2);
    }
    else if (numero2 > numero)
    {
      mcd = euclides(numero2, numero);
    }
    else
    {
      mcd = numero;
    }

    // validar que el numero sea menor al limite

    Console.WriteLine("MCD: " + mcd);

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

  static int euclides(int a, int b)
  {
    int residuo;
    while (true)
    {
      residuo = a % b;
      if (residuo == 0) return b;
      a = b;
      b = residuo;
    }
  }
}