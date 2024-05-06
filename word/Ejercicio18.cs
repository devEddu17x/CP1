using System;

class Ejercicio18
{
  /*

  Escribir un programa en C# que calcule e imprima el número de cifras de un
  número ingresado por el usuario, mostrando además la suma de sus dígitos y
  validando que el número ingresado sea un número entero no negativo.

  */
  static void x()
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
    int contador = 0;
    while (numero > 0)
    {
      suma += numero % 10;
      contador++;
      numero /= 10;
    }

    Console.WriteLine("La cantidad de digitos es: " + contador);
    Console.WriteLine("La suma de sus digitos es: " + (suma));
  }


}