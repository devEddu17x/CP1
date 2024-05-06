class Funciones
{
  /*
  Desarrollar un programa en C# que solicite al usuario un número
  y luego imprima todos los números primos menores que ese número,
  utilizando el algoritmo de la criba de Eratóstenes y
  mostrando los números primos encontrados.

  */
  static void x()
  {
    // si un numero es primo o no
    int numero = 13;
    bool primo = esPrimo(numero);
    Console.WriteLine("el numero " + numero + "primo? = " + primo);
  }

  // funcion que me de el factorial de un numero
  static bool esPrimo(int numero)
  {
    if (numero == 1 || numero == 0) return false;
    for (int i = 2; i < numero; i++)
    {
      if (numero % i == 0) return false;
    }
    return true;
  }


  // DECLARACION DE METODO

  //static tipoDeRetorno nombreDeMetodo (tipoDeDato nombre){

  //}


  // TIPOS DE RETORNO
  // void -> no retorna nada
  // int -> retorna un numero
  // string -> retorna una palabra
  // double -> numero decimal


}