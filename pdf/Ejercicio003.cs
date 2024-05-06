using System;
class Ejercicio003
{
  /*
  Diseñe un algoritmo que permita ingresar una cantidad incierta de números enteros positivo.
  Para cada número ingresado mostrar su número invertido y su número de cifras.
  */
  static void e3()
  {
    // introducir dos números positivos por teclado.
    string opcion = "";
    while (opcion != "n")
    {
      int n1 = getPositivo("Introduce un entero positivo N: ");
      imprimir(n1);
      Console.Write("Desea continuar (s/n): ");
      opcion = Console.ReadLine().ToLower();
    }

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

  static void imprimir(int n)
  {
    Console.WriteLine($"Invertido: {invertido(n)} Cifras: {cifras(n)}");
  }

  static int invertido(int n)
  {
    // string nString = n.ToString();
    // char[] invertido = nString.ToCharArray();
    // Array.Reverse(invertido);
    // string invertidoString = new string(invertido);
    // int invertidoInt = int.Parse(invertidoString);
    // return invertidoInt;

    int invertido = 0;
    while (n > 0)
    {
      invertido = invertido * 10 + n % 10;
      n /= 10;
    }

    return invertido;
  }

  static int cifras(int n)
  {
    // string nString = n.ToString();
    // return nString.Length;

    int cifras = 0;
    while (n > 0)
    {
      n /= 10;
      cifras++;
    }


    return cifras;
  }

}