using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_metodos1
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodo principal de ejecucion del sistema
            MostrarMenu();//invocamos al metodo para mostrar menu
            int numero_opcion = ObtenerNumero(); //recepcionamos la variable almacenandola en una variable int del mismo tipo del metodo e igualando hacia la invocacion del mismo
            //solicitamos los numeros para ser operados
            Console.WriteLine("Introduzca primer numero");
            double primer_numero = Convert.ToDouble(Console.ReadLine()); // almacenamos el primer numero en una variable double
            Console.WriteLine("Introduzca segundo numero");
            double segundo_numero = Convert.ToDouble(Console.ReadLine()); // almacenamos el segundo numero en una variable double
            switch (numero_opcion){ //este switch nos servira para verificar la opcion elegida
                case 1:
                    Console.WriteLine("La suma de los numero es" + Sumar(primer_numero,segundo_numero));
                    //imprimos la suma
                    // invocamos el metodos(variables para ser enviadas al metodo)
                    break;
                case 2:
                    Console.WriteLine("La suma de los numero es" + Restar(primer_numero, segundo_numero));
                    //imprimos la resta
                    // invocamos el metodos(variables para ser enviadas al metodo)
                    break;
                case 3:
                    Console.WriteLine("La suma de los numero es" + Multiplicar(primer_numero, segundo_numero));
                    break;
                //imprimos la multiplicacion
                // invocamos el metodos(variables para ser enviadas al metodo)
                case 4:
                    Console.WriteLine("La suma de los numero es" + Dividir(primer_numero, segundo_numero));
                    break;
                //imprimos la division
                // invocamos el metodos(variables para ser enviadas al metodo)
                default:
                    Console.WriteLine("La opcion introducida es invalida");
                    break;
            }
            Console.ReadKey();
        }
        //metodos secundarios
        //metodo para mostrar el menu de la consola
        static void MostrarMenu() {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - Division");

        }
        static int ObtenerNumero()
        {   //metodo para recepcionar la opcion introducida
            Console.WriteLine("Introduzca un numero");
            int numero = Convert.ToInt32(Console.ReadLine()); //almacenamos en una variable el numero solicitado por consola
            return numero; //devolvemos la variable a la invocacion del metodo
        }
        static double Sumar(double num1, double num2) { //recibimos dos parametros de tipo double en nuestro metodo double
            //metodo para sumar numero
            double suma = num1 + num2; //guardamos en una variable la suma de los numero
            return suma; // devolvemos la suma a la invocacion del metodo
        }
        static double Restar(double num1, double num2)
        {
            double resta = num1 - num2;
            return resta;
        }
        static double Multiplicar(double num1, double num2)
        {
            double mult = num1 * num2;
            return mult;
        }
        static double Dividir(double num1, double num2)
        {
            double div = num1 / num2;
            return div;
        }
    }
}
