using System;

class Ejercicio22
{
  /*

  Escribir un programa en C# que calcule e imprima el número de Armstrong
  correspondiente a una posición ingresada por el usuario, utilizando
  recursión y mostrando el número de forma recursivado
  */
  static void E22()
  {
    // introducir dos números por teclado.
    int posicion = getPositivo("Ingrese la posicion a buscar: ");
    getAsmstrong(0, posicion, 1);
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


  static void getAsmstrong(int contador, int posicion, int numero)
  {
    if (contador == posicion) return;
    if (isArmstrong(numero))
    {
      Console.WriteLine((contador + 1) + ". Es un armstrong: " + numero);
      getAsmstrong(contador + 1, posicion, numero + 1);
    }
    else
    {
      getAsmstrong(contador, posicion, numero + 1);
    }
  }

  static bool isArmstrong(int n)
  {
    int numeroOrignal = n;
    int suma = 0;
    int potencia = nDigitos(n);
    while (n > 0)
    {
      int digito = n % 10;
      suma += (int)Math.Pow((double)digito, potencia);
      n /= 10;
    }

    return suma == numeroOrignal;
  }
  static int nDigitos(int n)
  {
    int contador = 0;
    while (n > 0)
    {
      contador++;
      n /= 10;
    }

    return contador;
  }

}