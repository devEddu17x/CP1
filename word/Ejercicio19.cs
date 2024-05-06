using System;

class Ejercicio19
{
  /*

  Implementar un programa en C# que solicite al usuario un número y luego
  imprima si es un número de Harshad o no, mostrando la suma de sus dígitos
  y verificando su divisibilidad. Además, el programa debe permitir al usuario
  ingresar varios números y mostrar los resultados para cada uno.

  */
  static void E19()
  {
    // introducir dos números por teclado.
    int n = getPositivo("Numeros a ingresar: ");
    int[] numeros = new int[n];
    for (int i = 0; i < n; i++)
    {
      numeros[i] = getPositivo("Ingresa un numero entero positivo: ");
    }
    imprimir(numeros);

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
  static void imprimir(int[] numeros)
  {
    for (int i = 0; i < numeros.Length; i++)
    {
      esHarshad(numeros[i]);
    }
  }

  static void esHarshad(int numero)
  {
    int suma = getSuma(numero);
    if (esDvisible(numero, suma))
    {
      Console.WriteLine("Es Harshad: " + numero + "   suma de digitos: " + suma);

    }
  }


  static int getSuma(int numero)
  {
    int suma = 0;
    while (numero > 0)
    {
      suma += numero % 10;
      numero /= 10;
    }

    return suma;
  }

  static bool esDvisible(int numero, int suma)
  {
    return numero % suma == 0;
  }


}