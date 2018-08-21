using System;

namespace AprendiendoC_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hola Mundo
            //Console.WriteLine("Hello World!");
            
            //Coger entrada del usuario
/* 
            string name;
            Console.WriteLine("Cual es tu nombre?");
             name = Console.ReadLine();
             Console.WriteLine("Hola {0}", name);

             //Tomar entrada del usuario como numero
             Console.WriteLine("Cual es tu edad?");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("tu edad es: {0}",age);
        
            //Tomar entrada del usuario como numero con varible var
             Console.WriteLine("Cual es tu edad? con var");
             var age2 = Console.ReadLine();
             Console.WriteLine("tu edad es: {0}", age2);

             //Varible Constante
             const double altura = 1.70;
             Console.WriteLine("Tu altura es: {0} m", altura );
*/

            //Operadores Aritmeticos
            
            Console.WriteLine("Ingrese el valor de x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y");
            int y = Convert.ToInt32(Console.ReadLine());;
            //Suma
            Console.WriteLine("Suma {0}", x+y);
            //Resta
            Console.WriteLine("Resta {0}",x-y);
            //Multiplicacion
            Console.WriteLine("Multiplicacion {0}",x*y);
            //Division
            Console.WriteLine("Division {0}",x/y);
            //Residuo
            Console.WriteLine("Residuo {0}", x % y);
        }
    }
}
