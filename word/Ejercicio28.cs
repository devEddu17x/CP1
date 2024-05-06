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

class Ejercicio28
{
  static void x(string[] args)
  {
    int numero = getPositivo("Ingresa un entero positivo: ");
    imprimir(numero);

  }

  static void imprimir(int numero)
  {
    int[] primos = getPrimos(numero);

    int sumaDigitos = sumarDigitos(numero);
    int sumaDigitosPrimos = sumarDigitosPrimos(numero, primos);

    string factoresPrimos = obtenerFactoresPrimos(numero, primos);
    string digitos = getDigitos(numero);
    Console.WriteLine("Factores primos: " + factoresPrimos);
    Console.WriteLine("Digitos: " + digitos);
    Console.WriteLine("Suma de digitos: " + sumaDigitos);
    Console.WriteLine("Suma de digitos primos: " + sumaDigitosPrimos);
    string mensaje = (sumaDigitos == sumaDigitosPrimos) ? "Es un número de Smith" : "No es un número de Smith";
    Console.WriteLine(mensaje);
  }
  static string getDigitos(int numero)
  {
    string digitos = "";
    while (numero > 0)
    {
      digitos = (numero % 10) + " " + digitos;
      numero /= 10;
    }
    return digitos;
  }

  static int sumarDigitos(int numero)
  {
    int suma = 0;
    while (numero > 0)
    {
      suma += numero % 10;
      numero /= 10;
    }
    return suma;
  }

  static int sumarDigitosPrimos(int numero, int[] primos)
  {
    int suma = 0;
    int temp = numero;
    while (temp > 1)
    {
      int factor = obtenerFactorPrimo(temp, primos);
      suma += sumarDigitos(factor);
      temp /= factor;
    }
    return suma;
  }

  static int obtenerFactorPrimo(int numero, int[] primos)
  {
    foreach (int primo in primos) // 
    {
      if (numero % primo == 0)
      {
        return primo;
      }
    }
    return numero; // Si no se encuentra un factor primo, el número es primo
  }

  static string obtenerFactoresPrimos(int numero, int[] primos)
  {
    string factores = "";
    int temp = numero;
    while (temp > 1)
    {
      int factor = obtenerFactorPrimo(temp, primos);
      factores += factor + " x ";
      temp /= factor;
    }
    return factores.TrimEnd(' ', 'x', ' ');
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
}