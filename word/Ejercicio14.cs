using System;

class Ejercicio14
{
  /*

  Escribir un programa en C# que calcule e imprima la suma de los dígitos de un número 
  ingresado por el usuario, validando que el número ingresado sea un número entero no negativo 
  y mostrando la suma de los dígitos.

  */
  static void E14()
  {
    // introducir dos números por teclado.
    int n = getPositivo("Ingrese un numero: ");
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
    while (numero > 0)
    {
      suma += numero % 10;
      numero /= 10;
    }

    Console.WriteLine("La suma de los digitos es: " + suma);
  }


}