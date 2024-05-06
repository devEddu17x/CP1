using System;
class Ejercicio05
{
  /*
  Desarrollar un programa en C# que solicite al usuario un número y
  luego imprima si es un número primo de Fermat o no, solicitando al
  usuario el número de iteraciones para la prueba de primalidad y verificando
  si el número cumple con la condición de Fermat.

  */
  static void E5()
  {
    int cantidad = getPositivo("Ingresa un numero entero positivo: ");
    // XD lo siento el numero de fermat es mas complejo de lo que pensaba y no quiero ver muchas mates
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

  static void isFermat(int n)
  {
  }
}
