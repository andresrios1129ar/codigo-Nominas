using System;

namespace miapp
{
    class Program
    {
        static void Main(string[] args)
        {

            string salida = "";
            decimal hT = 0;
            decimal sH = 0;
            int t = 0;
            decimal sB = 0;
            decimal sN = 0;
            string Lector = "";
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("--Bienvenido al sistema de calcula de nomina Seccion 77 de Programacion Estructuda--");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("--Juan Perezo                       1-06-9999---------------------------------------");
            Console.WriteLine("--Pedro Almenz                       1-06-9999---------------------------------------");
            Console.WriteLine("--Lauroa Salem                       1-06-9999---------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Hey necesito las horas de Pedroq");
            Lector = Console.ReadLine();
            hT = Convert.ToDecimal(Lector);

            Console.WriteLine("Cual es el salaraio por hora de Pedro");
            sH = Convert.ToDecimal(Lector);

            Console.WriteLine("Ahora necesito el 1 o 2");
            t = Convert.ToInt32(Lector);


            sB = sH * hT;

            If (sB >= 100000)
            {
                If( t == 1 )
                {
                    sN = sB - (sB * 0.10);
                }
                ElseIf (t == 2)
                {
                    sN = sB - (sB * 0.15);
                }  
                Else
                {
                    Console.WriteLine("Debe digital, 1 o 2);
                    console.ReadKey();
                }
            }
            Else
            {
                sN = sB;
            }

            Console.WriteLine("Se gano:" + sN.ToString());
            console.ReadKey();
        }
    }
}