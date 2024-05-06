using System;
class Ejercicio03
{
  /*
  Implementar un programa en C# que solicite al usuario un número y 
  luego imprima si es un número feliz o no, mostrando la secuencia de
  sumas de cuadrados de dígitos y verificando si la secuencia llega al
  número 1 o si entra en un ciclo infinito.

  */
  static void E3()
  {
    int input = getPositivo("Ingresa un numero positivo");
    feliz(input);
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

  static void feliz(int n)
  {
    int numeroOriginal = n;
    int suma = 0;
    while (suma != 1 && suma != numeroOriginal)
    {
      int[] arreglo = getArreglo(n);
      suma = sumaArreglo(arreglo);
      imprimir(arreglo, suma);

      if (suma == numeroOriginal)
      {
        Console.WriteLine("Es infeliz y genera bucle infinito");
      }
      else if (suma == 1)
      {
        Console.WriteLine("Es feliz");
      }
      n = suma;
    }
  }

  static int[] getArreglo(int n)
  {
    // int[] arreglo = new int[tamaño]
    string nString = n.ToString(); // 132 -> "132" -> 0 -> 1 , 1 -> 3 , 2-> 2 -> string[] 
    int[] arreglo = new int[nString.Length];
    for (int i = 0; i < nString.Length; i++)
    {
      arreglo[i] = int.Parse(nString[i].ToString());
    }
    // Console.WriteLine(string.Join(" , ", arreglo));
    return arreglo;
  }
  static void imprimir(int[] arreglo, int suma)
  {
    for (int i = 0; i < arreglo.Length; i++)
    {
      if (i == arreglo.Length - 1)
      {
        Console.WriteLine(arreglo[i] + "^2 = " + suma);
      }
      else
      {
        Console.Write(arreglo[i] + "^2  +");
      }
    }
  }

  static int sumaArreglo(int[] arreglo)
  {
    int suma = 0;
    for (int i = 0; i < arreglo.Length; i++)
    {
      suma += (int)Math.Pow(arreglo[i], 2);
    }

    return suma;
  }
}