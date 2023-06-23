using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nota;
            int i = 1, Aprobados=0, Reprobados=0;
            while (i <= 10 )
            {
                Console.WriteLine("Nota {0}:", i);
                Nota = int.Parse(Console.ReadLine());

                if (Nota > 7) 
                {
                    Aprobados++;
                }
                else
                {
                    Aprobados++;
                }


                i++; 


            }
            Console.WriteLine("Aprobados: " + Aprobados + " Reprobados :" + Reprobados);
            Console.ReadLine();
        }
    }
}
