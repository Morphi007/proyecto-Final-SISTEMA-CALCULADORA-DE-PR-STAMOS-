using System;

namespace Proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {

           
                float cuota, interes, capital, Tasa, Balance, mensual;
                int i, Plazo;
                int orden;

                Console.Write("Introduce el monto delBalance:   \t");
                float.TryParse(Console.ReadLine(), out Balance);
                Console.Write("Introduce la tasa de interes anual:\t");
                float.TryParse(Console.ReadLine(), out Tasa);
                Console.Write("Introduce el plazo en meses:       \t");
                int.TryParse(Console.ReadLine(), out Plazo);

                //Calculo del interes mensual
                mensual = (Tasa / 100) / 12;




                //Calculo de la cuota mensual
                cuota = mensual + 1;
                cuota = (float)Math.Pow(cuota, Plazo);
                cuota = cuota - 1;
                cuota = mensual / cuota;
                cuota = mensual + cuota;
                cuota = Balance * cuota;
                orden = 1;

                Console.Clear();
                Console.Write("\n");
                Console.WriteLine($"\t\t\t\t\t\tMonto delBalance en RD$: {Balance}");
                Console.WriteLine();
                Console.WriteLine($"\t\t\t\t\t\tTasa de Porcentaje Anual: {Tasa }%");
                Console.WriteLine();
                Console.WriteLine($"\t\t\t\t\t\t       Plazo: {Plazo}:Meses");

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("      Pago       \t");
                Console.Write("cuota \t\t");
                Console.Write("\tIntereses       \t");
                Console.Write("Capital       \t\t");
                Console.Write("Balance          \t");
                Console.WriteLine();
                Console.WriteLine();



                for (i = 1; i <= Plazo; i++)
                {


                    Console.Write($"\t{orden} \t\t");


                    Console.Write($"{cuota}  \t");




                    interes = mensual * Balance;
                    Console.Write($"\t{interes}");

                    capital = cuota - interes;
                    Console.Write($"\t\t{capital}\t");



                    Balance = Balance - capital;
                    Console.Write($"\t{Balance}\t");

                    orden = orden + 1;
                    Console.WriteLine();

                }
                Console.ReadLine();
            }

        }
    }

