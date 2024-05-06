using System;

class Ejercicio24
{
  /*

Desarrollar un programa en C# que solicite al usuario un número y luego
imprima si es un número de Kaprekar o no, mostrando todos los pasos del
proceso de Kaprekar y verificando si el número cumple con la propiedad de
Kaprekar.

  */
  static void x()
  {
    int n = getPositivo("Ingrese un numero entero positivo: ");
    kaprekar(n);
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



  private static void kaprekar(int n)
  {
    int cuadrado = n * n;
    int tamaño = nDigitos(cuadrado);
    Console.WriteLine("n: " + n);
    Console.WriteLine("cuadrado: " + cuadrado);

    int primerNumero, segundoNumero;
    if (tamaño % 2 != 0)
    {
      primerNumero = primeraParte(cuadrado, tamaño + 1);
      segundoNumero = segundaParte(cuadrado, tamaño + 1);
    }
    else
    {
      primerNumero = primeraParte(cuadrado, tamaño);
      segundoNumero = segundaParte(cuadrado, tamaño);
    }
    imprimir(n, cuadrado, primerNumero, segundoNumero);
  }

  private static void imprimir(int n, int cuadrado, int primerNumero, int segundoNumero)
  {
    Console.WriteLine(primerNumero + " + " + segundoNumero + " = " + (primerNumero + segundoNumero));
    if (primerNumero + segundoNumero == n)
    {
      Console.WriteLine((primerNumero + segundoNumero) + " = " + n + " ES un numero Kaprekar");
    }
    else
    {
      Console.WriteLine((primerNumero + segundoNumero) + " != " + n + " NO es un numero Kaprekar");
    }
  }

  private static int primeraParte(int numero, int cantidadCifras)
  {
    if (cantidadCifras == 1) return numero;
    for (int i = 0; i < cantidadCifras / 2; i++)
    {
      numero /= 10;
    }
    return numero;
  }

  private static int segundaParte(int numero, int cantidadCifras)
  {
    if (cantidadCifras == 1) return 0;
    int nuevoNumero = 0;
    int multiplicador = 1;
    for (int i = 1; i <= cantidadCifras / 2; i++)
    {
      nuevoNumero = numero % 10 * multiplicador + nuevoNumero;
      multiplicador *= 10;
      numero /= 10;
      // Console.WriteLine("cifra: " + cifra);
      // Console.WriteLine("nuevo numero: " + nuevoNumero);
      // Console.WriteLine("numero: " + numero);
    }
    return nuevoNumero;
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