using System;

class Ejercicio15
{
  /*

  Implementar un programa en C# que solicite al usuario un número y
  luego imprima si es un número de Armstrong o no, además de indicar
  cuántos dígitos tiene el número y mostrando el resultado del cálculo.

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
    if (isArmstrong(numero))
    {
      Console.WriteLine("Es armstrong. Cantidad de digitos: " + nDigitos(numero));
    }
    else
    {
      Console.WriteLine("No es armstrong. Cantidad de digitos: " + nDigitos(numero));
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