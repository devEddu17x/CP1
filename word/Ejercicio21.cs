using System;

class Ejercicio21
{
  /*

  Crear un programa en C# que genere e imprima los primeros 30 números 
  abundantes, permitiendo al usuario elegir el límite superior del rango
  y mostrando los números encontrado
  */
  static void E21()
  {
    // introducir dos números por teclado.
    int limite = getPositivo("Ingrese un limite hasta donde buscar entero positivo: ");
    imprimir(limite);
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
  static void imprimir(int limite)
  {
    int contador = 0;
    for (int i = 0; i < limite; i++)
    {
      if (contador == 30) break;
      if (esAbundante(i))
      {
        Console.WriteLine(++contador + ". Es abundante: " + i);
      }
    }
  }

  static bool esAbundante(int numero)
  {
    int suma = 0;
    int mitad = ((int)numero / 2) + 1;

    for (int i = 1; i <= mitad; i++)
    {
      if (numero % i == 0)
      {
        suma += i;
      }
    }

    return suma > numero;
  }

}