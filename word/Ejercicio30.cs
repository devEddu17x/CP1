
class Ejercicio30
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