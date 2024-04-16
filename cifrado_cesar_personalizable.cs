using System;

class Program {

  static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

  //FUNCION CIFRAR
  public string Cifrar(string mensaje, int distancia)
  {    

      while(distancia > alfabeto.Length){
        distancia = distancia - alfabeto.Length;
      }
      string cifrado = "";
      for (int indice = 0; indice < mensaje.Length; indice++)
      {
        if (mensaje[indice] == ' ')
        {
          cifrado += mensaje[indice];
        }
        else
        {
          char caracter = mensaje[indice];
          for (int i = 0; i < alfabeto.Length; i++)
          {
            if (caracter == alfabeto[i])
            {
              if (i < (alfabeto.Length - distancia))
              {
                  cifrado += alfabeto[i + distancia];
              }
              else
              {
                int cantidadAlFinal = alfabeto.Length - i;
                int nuevoIndice = distancia - cantidadAlFinal;
                cifrado += alfabeto[nuevoIndice];
              }
            }
          }
        }
      }
    return cifrado;
  }

  //FUNCION DESCIFRAR
  public string Descifrar(string mensajeCifrado, int distancia)
  {  
      while(distancia > alfabeto.Length){
        distancia = distancia - alfabeto.Length;
      }
      string descifrado = "";
      for (int indice = 0; indice < mensajeCifrado.Length; indice++)
      {
          if (mensajeCifrado[indice] == ' ')
          {
              descifrado += mensajeCifrado[indice];
          }
          else
          {
              char caracter = mensajeCifrado[indice];
              for (int i = 0; i < alfabeto.Length; i++)
              {
                  if (caracter == alfabeto[i])
                  {
                      if (i > 6 && i < alfabeto.Length)
                      {
                          descifrado += alfabeto[i - distancia];
                      }
                      else
                      {
                        int nuevoIndice = alfabeto.Length - (distancia-i);
                        descifrado += alfabeto[nuevoIndice];
                      }
                  }
              }

          }
      }

      return descifrado;
  }

  public static void Main (string[] args) {

    Program programa = new Program();

    Console.WriteLine("Ingrese el mensaje a cifrar: ");
    string mensajeCifrar = Console.ReadLine();
    while(string.IsNullOrEmpty(mensajeCifrar))
    {
      Console.WriteLine("Ingrese un mensaje no vacío");
      mensajeCifrar = Console.ReadLine();
    }

    Console.WriteLine("Ingrese una distancia para el cifrado:");
    int distancia = Convert.ToInt32(Console.ReadLine());

    //Funcion Cifrado
      string mensajeCifrado = programa.Cifrar(mensajeCifrar, distancia);
      Console.WriteLine("El mensaje cifrado es:" + mensajeCifrado);

    //Funcion Descifrado
      string mensajeDescifrado = programa.Descifrar(mensajeCifrado, distancia);
      Console.WriteLine("El mensaje descifrado es:" + mensajeDescifrado);

  }
}
