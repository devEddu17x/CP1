using System;
class Ejercicio01
{
  /*
  Desarrollar un programa en C# que calcule e imprima todos los números de 
  Armstrong menores que un número ingresado por el usuario, validando que el
  número ingresado sea positivo y menor que un límite máximo especificado por el usuario.

  */
  static void E1()
  {
    // introducir dos números por teclado.
    int limite = getPositivo("Ingresa el limite entero positivo: ");
    int numero = getPositivo("Introduce un entero positivo menor al limite: ");

    // validar que el numero sea menor al limite
    while (numero >= limite)
    {
      numero = getPositivo("Ingresa un numero menor al limite: ");
    }

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
    for (int i = 1; i <= numero; i++)
    {
      if (isArmstrong(i))
      {
        Console.WriteLine("es armstrong: " + i);
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