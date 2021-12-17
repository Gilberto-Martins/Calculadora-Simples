using System;
using Calculadora_slp.Classes;

namespace Calculadora_slp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalMetos op = new CalMetos();

            Console.Clear();
            Console.WriteLine("--Calculadora--");

            Console.WriteLine("Qual operação deseja realizar e em sequida ensira os valores da operação");
            Console.WriteLine("1 Para Somar, 2 Para Subtrair, 3 Para Multiplicar e 4 Para Dividir");

            int ope;
            double x , y;
            bool continuar;
            char valid;

            do
            {
                switch (ope = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(op.Soma(x, y));
                        break;

                    case 2:
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(op.Sub(x , y));
                        break;

                    case 3:
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(op.Mult(x, y));
                        break;

                    case 4:
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(op.Divi(x, y));
                        break;

                    default:
                        Console.WriteLine("--Operação não encontrada--");
                        break;
                }
                Console.WriteLine("Deseja repetir a operação? S / N");
                valid = Convert.ToChar(Console.ReadLine());
                if(valid == 'S')
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            }while(continuar);
        }
    }
}
