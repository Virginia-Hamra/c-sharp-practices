using System;


//namespace ejer3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double nota1, nota2, nota3, promedio;

//            Console.Write("Ingrese nota 1: ");
//            nota1 = int.Parse(Console.ReadLine());
//            Console.Write("Ingrese nota 2: ");
//            nota2 = int.Parse(Console.ReadLine());
//            Console.Write("Ingrese nota 3: ");
//            nota3 = int.Parse(Console.ReadLine());

//            promedio = (nota1 + nota2 + nota3) / 3;
//            Console.WriteLine("Su promedio es: {0}", promedio);
//            Console.ReadKey();

//        }
//    }
//}

//namespace ejer3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int pGanados, pEmpatados, pFinal;

//            Console.Write("Ingrese cantidad de partidos ganados: ");
//            pGanados = int.Parse(Console.ReadLine());
//            Console.Write("Ingrese cantidad de partidos empatados: ");
//            pEmpatados = int.Parse(Console.ReadLine());

//            pFinal = (pGanados * 3) + (pEmpatados * 1);
//            Console.WriteLine("Su puntaje final es: {0}", pFinal);
//            Console.ReadKey();

//        }
//    }
//}

namespace ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            double suma, promedio, p1, p2, pR, p2R;

            Console.Write("Ingrese nro a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nro b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nro c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nro d: ");
            d = int.Parse(Console.ReadLine());

            suma = a + b + c + d;
            promedio = (suma / 4);
            pR = Math.Round(promedio, 2);

            p1 = (a*100) / c;
            p2 = (d * 100) / suma;
            p2R = Math.Round(p2, 2);


            Console.WriteLine("Su promedio es: {0}", pR);
            Console.WriteLine("El porcentaje de nro1 con respecto a nro3 es: {0}", p1);
            Console.WriteLine("El porcentaje de nro4 con respecto a la suma de todos los valores es: {0}", p2R);
            Console.ReadKey();

        }
    }
}
