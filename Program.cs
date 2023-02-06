using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.el_volumen_de_las_figuras_geométricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una figura geométrica:");//Aqui establecemos para que el usuario eliga, la figura que desea calcular.
            Console.WriteLine("1. Cubo");
            Console.WriteLine("2. Esfera");
            Console.WriteLine("3. Cono");
            Console.WriteLine("4. Pirámide");
            int option = int.Parse(Console.ReadLine());//Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.

            switch (option) //selecciona una lista de instrucciones para ejecutarse en función de una coincidencia de patrón con una expresión.
            {
                case 1:
                    Console.WriteLine("Ingrese la longitud de un lado del cubo:");
                    double side = double.Parse(Console.ReadLine()); ////Convierte la representación en forma de cadena de un número en el número de punto flotante de precisión doble equivalente.
                    Console.WriteLine("El volumen del cubo es: " + side * side * side); //aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
               
                case 2:
                    Console.WriteLine("Ingrese el radio de la esfera:");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("El volumen de la esfera es: " + (4 / 3) * Math.PI * radius * radius * radius);//aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
               
                case 3:
                    Console.WriteLine("Ingrese el radio del cono:");
                    double radiusCone = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del cono:");
                    double heightCone = double.Parse(Console.ReadLine());
                    Console.WriteLine("El volumen del cono es: " + (Math.PI * radiusCone * radiusCone * heightCone) / 3);//aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
               
                case 4:
                    Console.WriteLine("Ingrese la longitud de la base de la pirámide:");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura de la pirámide:");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("El volumen de la pirámide es: " + (baseLength * height) / 3);//aqui la formula para realizar el calculo.
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
                
                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadLine();//para imprimir en pantalla el resultado de la operacio.
                    break;
            }
        }
    }
}