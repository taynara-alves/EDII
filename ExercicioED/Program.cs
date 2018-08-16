using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioED
{
    class Program
    {
        class Tempo
        {
            public int qtde;
            public double[,] tempo = new double[15, 3];

            public void entraTempos()
            {
               

                for (int l = 0; l < 3; l++)
                {

                    Console.WriteLine((l+1) + " volta");

                    for (int i = 0; i < 15; i++)
                    {
                        double temp = 0;
                        Console.WriteLine("tempo do carro " + (i + 1));
                        temp = Convert.ToDouble(Console.ReadLine());
                        tempo[i, l] = temp;



                    }
                }

                for (int l = 0; l < 3; l++)
                {
                    Console.WriteLine("\n\n" + (l+1) + " volta");
                    for (int i = 0; i < 15; i++)
                    {
                        Console.WriteLine("\n"+tempo[i, l]+"\n");

                    }
                }


            }

            public void mediaCarros()
            {

            }

            public void mediaVoltas()
            {

            }

            public void montaGrid()
            {

            }

        }
        static void Main(string[] args)
        {


            Tempo tempo = new Tempo();

            tempo.entraTempos();

            Console.ReadKey();
            

        }

    
    }
}
