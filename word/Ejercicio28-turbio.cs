// using System;
// using System.Security.Cryptography;
// class Ejercicio28
// {
//   /*
//   Desarrollar un programa en C# que calcule e imprima todos los números de 
//   Armstrong menores que un número ingresado por el usuario, validando que el
//   número ingresado sea positivo y menor que un límite máximo especificado por el usuario.

//   */
//   static void x()
//   {
//     // introducir dos números por teclado.
//     int numero = getPositivo("Introduce un entero positivo: ");

//     // validar que el numero sea menor al limite
//     smith(numero);

//   }
//   static int getPositivo(string mensaje)
//   {
//     int n;
//     n = getN(mensaje);
//     while (n <= 0)
//     {
//       n = getN(mensaje);
//     }

//     return n;
//   }
//   static int getN(string mensaje)
//   {
//     Console.Write(mensaje);
//     int n;
//     while (!int.TryParse(Console.ReadLine(), out n))
//     {
//       Console.Write(mensaje);
//     }
//     return n;
//   }

//   static void smith(int numero)
//   {
//     // hallar sus factores primos

//   }
//   static bool esDivisible(int numero, int divisor)
//   {
//     return numero % divisor == 0;
//   }

//   static void erastotenes(int numero)
//   {
//     bool[] esPrimo = new bool[numero + 1]; // numero fuera 4 -> [0, 1, 2, 3, 4]

//     for (int i = 0; i < esPrimo.Length; i++) // llenar todo de true
//     {
//       esPrimo[i] = true;
//     }

//     for (int i = 2; i * i <= numero; i++) // i = 2  -> [0, 1, "2", 3, 4]
//     {
//       if (esPrimo[i])
//       {
//         for (int j = i * i; j <= numero; j += i) // j = i * i ; i = 2; j = 4 -> /4 /1 /2 -> no es primo -> divisores >= 3 
//         {
//           esPrimo[j] = false;
//         }
//       }
//     }
//   }

//   static int[] primos(bool[] esPrimo, int numero)
//   {
//     int[] primos = new int[esPrimo.Length];
//     int index = 0;
//     for (int i = 2; i <= numero; i++)
//     {
//       if (esPrimo[i])
//       {
//         primos[index] = i;
//         index++;
//       }
//     }

//     return primos;
//   }
//   static void factoresPrimos(int[] primos, int numero)
//   {
//     int[] factores = new int[primos.Length];
//     int contador = 0;
//     int suma = 1;
//     for (int i = 0; i < primos.Length / 2 + 1; i++)
//     {
//       if (esDivisible(numero, primos[i]))
//       {
//         suma *= primos[i];
//         if (suma > numero)
//         {
//           suma /= primos[i];
//         }
//         factores[contador] = primos[i];
//         contador++;
//       }
//     }
//   }

// }
using System;
using System.Collections.Generic;

class EjercicioTurbio
{
  static void x(string[] args)
  {
    int numero = getPositivo("Introduce un entero positivo: ");
    imprimir(numero);
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
    int[] primos = getPrimos(n);
    int sumaDeDigitos = mostrarYSumarDigitos(n);
    string factoresStr = factoresPrimos(primos, n);
    int sumaFactores = sumaDigitosFactores(factoresStr);

    Console.WriteLine("Factores primos: " + factoresStr);
    Console.WriteLine("Suma de factores primos: " + sumaFactores);
    Console.WriteLine("Suma de digitos: " + sumaDeDigitos);
    string mensaje = (sumaDeDigitos == sumaFactores) ? "Es un numero de Smith" : "No es un numero de Smith";
    Console.WriteLine(mensaje);
  }

  static int mostrarYSumarDigitos(int n)
  {
    int suma = 0;
    string digitos = "";
    Console.Write("Digitos: ");
    while (n > 0)
    {
      digitos = n % 10 + " " + digitos;
      suma += n % 10;
      n /= 10;
    }
    Console.WriteLine(digitos);
    return suma;
  }

  static int sumaDigitosFactores(string factores)
  {
    int suma = 0;
    for (int i = 0; i < factores.Length; i++)
    {
      if (factores[i] != ' ' && factores[i] != '*') suma += int.Parse(factores[i].ToString());
    }
    return suma;
  }
  static int[] getPrimos(int numero)
  {
    int count = 0;
    bool[] booleano = new bool[numero + 1];
    for (int i = 0; i <= numero; i++)
    {
      if (esPrimo(i) && i != numero)
      {
        booleano[i] = true;
        count++;
      }
    }

    int[] primos = new int[count];
    count = 0;
    for (int i = 0; i <= numero; i++)
    {
      if (booleano[i])
      {
        primos[count] = i;
        count++;
      }

    }
    if (count == 0)
    {

      primos[count - 1] = numero;
    }
    return primos;

  }

  static bool esPrimo(int n)
  {
    if (n == 1 || n == 0) return false;
    for (int i = 2; i < n; i++)
    {
      if (n % i == 0) return false;
    }
    return true;
  }

  static string factoresPrimos(int[] primos, int numero)
  {
    // retorna todos los factores primos en froma de string
    // ejem n = 15 -> return 3 * 5 *
    int contador = 0;
    string factores = "";
    int suma = 0;
    for (int i = 0; i < primos.Length; i++)
    {
      if (numero % primos[i] == 0)
      {
        suma *= primos[i];
        factores += primos[i] + " * ";
        contador++;
        if (suma == numero) break;
      }
    }
    if (contador == 0) return "";
    return factores.TrimEnd(" * ".ToCharArray());
  }


}