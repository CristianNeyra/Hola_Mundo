using System;

namespace Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String Texto;
            Char Respuesta;

            //Despliega un mensaje por pantalla
            Console.WriteLine("Hola mundo");
            Console.WriteLine("");

        Label:
            //Lee y desplieda valores ingresados por consola
            Console.WriteLine("Ingrese una cadena de texto: ");
            Texto = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("La cadena ingresada es: " + Texto);
            Console.WriteLine("");

        Label2:
            //Siclo de control para auto ejecución hasta recivir orden de terminación
            Console.WriteLine("Desea continuar? Si(s)/No(n)");
            Respuesta = Convert.ToChar(Console.ReadLine().ToLower());  //Formatea la entrada a minusculas

            switch(Respuesta){
                case 's':
                    goto Label; //Regresa la ejecución del programa a la posición de la etiqueta señalada
                case 'n':
                    goto label3; //Regresa la ejecución del programa a la posición de la etiqueta señalada
                default:
                    Console.WriteLine("Debe ingresar una de las dos respuestas validas");
                    Console.WriteLine("");
                    goto Label2; //Regresa la ejecución del programa a la posición de la etiqueta señalada
            }
            
        label3:
            //Termina la ejecución del programa
            Environment.Exit(1);


        }
    }
}
