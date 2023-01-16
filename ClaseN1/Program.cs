using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu de opciones
            double a, b, c;
            int opc;
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1.Suma (a+b)");
            Console.WriteLine("2.Resta (a-b)");
            Console.WriteLine("3. Multiplicacion (a*b)");
            Console.WriteLine("4. Division (a/b)");
            Console.WriteLine("5. Lista de Abcedario");
            Console.WriteLine("0. Salir");

            switch (opc)
            {
                case 0: 
                    Console.WriteLine("Ha elegido salir");
                    break;

                    case 1:
                    Console.WriteLine("Ha elegido Sumar");
                    Console.WriteLine("Ingrese el valor de a ");
                    a=double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de b ");
                    b=double.Parse(Console.ReadLine());

                    c = a + b;
                    Console.WriteLine("El resultado de la operacion es : "+c);
                    break;

                case 2:
                    Console.WriteLine("Ha elegido Restar");
                    Console.WriteLine("Ingrese el valor de a ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de b ");
                    b = double.Parse(Console.ReadLine());

                    c = a - b;
                    Console.WriteLine("El resultado de la operacion es : "+c);
                    break;

                case 3:
                    Console.WriteLine("Ha elegido Multiplicar");
                    Console.WriteLine("Ingrese el valor de a ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de b ");
                    b = double.Parse(Console.ReadLine());

                    c = a * b;
                    Console.WriteLine("El resultado de la operacion es : " + c);
                    break;

            }
            

            /*/Numeros Ascendentes
            int numero;
            Console.WriteLine("Ingrese el valor del numero ");
            numero = int.Parse(Console.ReadLine());
            do
            {
                if (numero % 1 == 0)
                {
                    numero++;
                    Console.WriteLine(numero);
                }
            } while (numero >=50);
            /*/

            /*/Numeros descendentes
            int numero; 
            Console.WriteLine("Ingrese el valor del numero ");
            numero=int.Parse(Console.ReadLine());
            do
            {
                if (numero % 2 == 0) 
                {
                    Console.WriteLine(  numero );
                }
            } while (numero > 0);
            /*/

            /*/Realizar la division entre dos numeros y validarlos

            double a, b, c;

            do
            {
                Console.WriteLine("Ingrese un numerador");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el denumerador");
                b = double.Parse(Console.ReadLine());

                if (b <= 0)
                {
                    Console.WriteLine("La division entre 0 o numeros negativos no existe, ingreselo nuevamente");
                    Console.WriteLine(" ");
                }
                else
                {
                    c = a / b;
                    Console.WriteLine("El Cociente es : " + c);
                    Console.ReadKey();
                }

            } while ( b <= 0);
            /*/



            /*/Validaciones
            int a, b, c;

            do
            {
                Console.WriteLine("Ingrese un numero");
                a=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otor numero");
                b=int.Parse(Console.ReadLine());


            }while (a<=0 || b<=0);

            c = a + b;
            Console.WriteLine("La suma es :" + c);
            Console.ReadKey();
            /*/

            /*/Calcule el area de un circulo
            double area, radio;
            Console.WriteLine("Ingrese el Radio");
            radio=double.Parse(Console.ReadLine());
            area = (Math.PI) * (Math.Pow(radio, 2));

            Console.WriteLine("El Area del Circulo es de : "+area);
            Console.ReadKey();
            /*/


            /*/Programa para saber si un numero es par
            int a;
            Console.WriteLine("Ingrese el numero ");
            a=int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();
            /*/

            /*/Calcular la potencia de un numero
            double x, z, y;
            Console.WriteLine("Ingrese el valor de la base");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del exponente");
            y=double.Parse(Console.ReadLine());

            z = Math.Pow(x, y);
            Console.WriteLine("La potencia del numero que ingreso es: "+z);
            Console.ReadKey();

            /*/


            /*/Este es un programa para sumar dos numeros

            int a, b, c;
            Console.WriteLine("Ingresa el Primer Numero ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Segundo Numero ");
            b=int.Parse(Console.ReadLine());

            c= a +b;
            Console.WriteLine("El Resultado es: "+c);  
            /*/
        }   
    }

}
