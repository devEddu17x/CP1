using System;
class Ejercicio07
{
  /*
  Implementar un programa en C# que solicite al usuario un número y luego imprima
  todos los números narcisistas menores que ese número, validando que el número
  ingresado sea positivo y mostrando todos los números narcisistas encontrados.

  */
  static void x()
  {
    // introducir dos números por teclado.
    int numero = getPositivo("Introduce un numero entero: ");
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
    Console.WriteLine("Numeros narcisistas menores que " + numero + ": ");
    for (int i = numero; i >= 1; i--)
    {
      if (isArmstrong(i))
      {
        Console.WriteLine("es narcisista: " + i);
      }
    }
  }
  static bool isArmstrong(int n)
  {
    int numeroOrignal = n;
    int suma = 0;
    int potencia = nDigitos(n);
    while (n > 0)
    {
      int digito = n % 10;
      suma += (int)Math.Pow((double)digito, potencia);
      n /= 10;
    }

    return suma == numeroOrignal;
  }
  static int nDigitos(int n)
  {
    int contador = 0;
    while (n > 0)
    {
      contador++;
      n /= 10;
    }

    return contador;
  }
}