using System;
class Ejercicio001
{
  /*
  Introducir dos números por teclado. Imprimir los números naturales que hay entre ambos
  números empezando por el más pequeño, contar cuantos hay y cuantos de ellos son pares.
  Calcular la suma de los impares.
*/
  static void e1()
  {
    // introducir dos números por teclado.
    int n1 = getN("Introduce un entero valido N1: ");
    int n2 = getN("Introduce un entero valido N2: ");

    // validar si son iguales
    if (n1 == 2)
    {
      Console.Write("Ambos numeros son iguales");
    }
    // solucion general del problema
    else if (n1 < n2)
    {
      imprimir(n1, n2);
    }
    else
    {
      imprimir(n2, n1);
    }
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

  static void imprimir(int menor, int mayor)
  {
    int cantidad, pares = 0, sumaImpares = 0;
    cantidad = mayor - menor + 1;
    Console.WriteLine($"Los numeros impresos del menor [{menor}] al mayor [{mayor}] son: ");
    for (int i = menor; i <= mayor; i++)
    {
      if (i % 2 == 0)
      {
        pares++;
        Console.WriteLine(i + " par   cantidad pares = " + pares);
      }
      else
      {
        Console.WriteLine(i + " impar");

        sumaImpares += i;
      }
    }
    Console.WriteLine($"\nLa cantidad total de numeros es: {cantidad}");
    Console.WriteLine($"La cantidad de pares es: {pares}");
    Console.WriteLine($"La suma de los impares es: {sumaImpares}");
  }
}