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
*/
             //Tomar entrada del usuario como numero
             Console.WriteLine("Cual es tu edad?");
             var age = Console.ReadLine();
             Console.WriteLine("tu edad es: {0}",age);
/*       
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
            //condicionales

            if(x > y){
                //Suma
                Console.WriteLine("Suma {0}", x+y);
                //Resta
                Console.WriteLine("Resta {0}",x-y);
            }else{
                //Multiplicacion
                Console.WriteLine("Multiplicacion {0}",x*y);
                //Division
                Console.WriteLine("Division {0}",x/y);
            }
            //switch o casos
            if(y==x){
                switch(y){
                    case 1:
                        //Residuo
                        Console.WriteLine("Residuo {0}", x % y);
                        break;
                    case 2:
                        //Operador de Asignacion
                        Console.WriteLine("X le sumamos 10 :{0}" , x+=10);
                        Console.WriteLine("y le restamos 3 :{0}" , y+=3);
                        break;
                    case 3:
                        Console.WriteLine("x lo multplicamos por 2 :{0}" , x*=2);
                        Console.WriteLine("y lo divimos entre 1: {0}" , y/=1);
                        break;
                    default:
                        //Incremento
                        Console.Write("Incrementamos x {0}" , x++);
                        //Decremento
                        Console.Write("Decrecemos  y {0}" , y++);
                        break;
                }
            }
            //ciclo while
            Console.WriteLine("ingrese el numero de veces del ciclo");
            var num = Console.ReadLine();
            while(num < 10){
                Console.WriteLine(num);
                num++;
            }

            //ciclo for
            for(int num; num<10;num++){
                Console.WriteLine("Valor de x :{0}" , x);
            }

            if(num == 6){
                for(;x<10;num+=2){
                    Console.WriteLine("Valor de x :{0}" , x);
                }
            }
            //do while
            do{
                Console.WriteLine(num);
                num++;
            }while(num < 10);

            for(;num>10;num++){
                if(num == 11)
                break;
                Console.WriteLine(num);
            }

            for(;num>5;num++){
                if(num == 3)
                continue;
                Console.WriteLine(num);
            }

            // operador ?:
            string msg;
            msg=(age >= 18)? "mayor de edad":"menor de edad";
            Console.WriteLine(msg);

            // calculadora basica

            do{
                Console.WriteLine("num1 = ");
                string str = Console.ReadLine();
                if(str == "exit")
                break;

                int num1 =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("num2 = ");
                int num2 =Convert.ToInt32(Console.ReadLine());
                
                int sum = num1+num2;
                Console.WriteLine("suma : {0}" , sum);

                int res = num1-num2;
                Console.WriteLine("resta: {0}" , res);

                int mul = num1*num2;
                Console.WriteLine("multiplicacion : {0}" , mul);
                
                if(num2 != 0)
                break;
                    int div = num1/num2;
                    Console.WriteLine("division : {0}" , div);
                    

            }while(true);


        }
    }
}
