using System;
class Ejercicio004
{
  /*
  Diseñe un programa que genere números aleatorios enteros del intervalo 100 a 999
  hasta obtener un número par mayor o igual a 500. Imprima lo números generados y
  determine:
  La suma de los números generados
  La cantidad de números pares generados
  La cantidad de números impares generados
  La suma de los números pares generados
  La suma de los números impares generados
  */
  static void e4()
  {
    // Generar numeros aleatorios enteros del intervalo 100 a 999
    Random random = new Random();
    int n, suma = 0, cantidadPares = 0, cantidadImpares = 0, sumaPares = 0, sumaImpares = 0;
    while (true)
    {
      // aqui se genera un numero entre a y b-1 -> 100 y 1000-1 -> 100 y 999
      n = random.Next(100, 1000);
      if (n % 2 == 0 && n >= 500)
      {
        Console.WriteLine("La suma de numeros es: " + suma);
        Console.WriteLine("La cantidad de numeros pares es: " + cantidadPares);
        Console.WriteLine("La cantidad de numeros impares es: " + cantidadImpares);
        Console.WriteLine("La suma de numeros pares es: " + sumaPares);
        Console.WriteLine("La suma de numeros impares es: " + sumaImpares);
        Console.WriteLine("EL numero que hizo acabar el programa es: " + n);
        break;
      }
      Console.WriteLine(n);
      if (n % 2 == 0)
      {
        cantidadPares++;
        sumaPares += n;
      }
      else
      {
        cantidadImpares++;
        sumaImpares += n;
      }
      suma += n;

    }

  }

}