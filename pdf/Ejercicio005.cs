using System;
class Ejercicio005
{
  /*
  Diseñe un programa que genere sueldos aleatorios enteros con valores del
  intervalo 2000 a 4000 hasta obtener un sueldo mayor de 2500 pero menor de 3500.
  Imprima los sueldos generados y determine:
  La suma de los sueldos generados
  La cantidad de sueldos < 2500
  La cantidad de sueldos = 2500 pero < 3000
  La cantidad de sueldos = 3000 pero < 3500
  La cantidad de sueldos >3500

  EJERCICIO MAL PLANTEADO
  */
  static void e5()
  {
    Random random = new Random();
    int n, suma = 0;
    int condicion1 = 0, condicion2 = 0, condicion3 = 0, condicion4 = 0;
    while (true)
    {
      n = random.Next(2000, 4001);
      if (n > 2500 && n < 3500)
      {
        Console.WriteLine("La suma de sueldos es: " + suma);
        Console.WriteLine("La cantidad de sueldos < 2500 es: " + condicion1);
        Console.WriteLine("La cantidad de sueldos = 2500 pero < 3000 es: " + condicion2);
        Console.WriteLine("La suma de numeros pares es: " + condicion3);
        Console.WriteLine("La cantidad de sueldos = 3000 pero < 3500s es: " + condicion4);
        Console.WriteLine("La cantidad de sueldos = 3500 es: " + n);
        break;
      }
      Console.WriteLine("Sueldo: " + n);
      if (n < 2500)
      {
        condicion1++;
      }
      else if (n == 2500 && n < 3000)
      {
        condicion2++;
      }
      else if (n == 3000 && n < 3500)
      {
        condicion3++;
      }
      else if (n == 3500)
      {
        condicion4++;
      }

      suma += n;
    }

  }

}