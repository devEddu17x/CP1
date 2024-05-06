using System;
class Ejercicio04
{
  /*
  Crear un programa en C# que genere e imprima los primeros 20 números de
  Fibonacci que sean divisibles por 3 y 5 simultáneamente, permitiendo al
  usuario especificar la cantidad de números que desea ver.

  */
  static void x()
  {
    int cantidad = getPositivo("Ingresa un numero entero positivo: ");
    fibonacci(cantidad);
  }

  static int getPositivo(string mensaje)
  {
    int n;
    Console.Write(mensaje);
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
      Console.Write(mensaje);
    }
    return n;
  }

  static void fibonacci(int max) // fb 3
  {
    int primero = 1, segundo = 0, fibonacci;
    while (max > 0)
    /*
    P    S    -> fibonacci = P + S
    1 + 0 = 1 -> fibonacci = 1 + 0 = 1
    1 + 1 = 2 -> fibonacci = 1 + 1 = 2
    2 + 1 = 3
    3 + 2 = 5
    5 + 3 = 8
    */
    {
      fibonacci = primero + segundo;


      if (fibonacci % 3 == 0 && fibonacci % 5 == 0)
      {
        Console.WriteLine(fibonacci + " ");
      }
      segundo = primero;
      primero = fibonacci;
      max--;
    }
  }
}
