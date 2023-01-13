using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            #region condição simples
            //int valor = 5;

            //if(valor == 10)
            //{
            //    Console.WriteLine("condição verdadeira!");
            //}

            //else
            //{
            //    Console.WriteLine("condição Falsa!");
            //}
            #endregion

            #region Condicionais encadeadas
            //int valor = 35;

            //if (valor <5)
            //{
            //    Console.WriteLine("condição verdadeira!");
            //}

            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("condição alternativa 1!");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("condição alternativa 2!");
            //}
            //else
            //{
            //    Console.WriteLine("condição final!");
            //}
            #endregion

            #region Condicionais aninhadas
            
            int numero = 11;
            if (numero >= 5)
            {
                Console.Write("O numero é maior que 5");

                if (numero % 2 == 0)
                {
                    Console.WriteLine(" e tambem é par");
                }

                else
                {
                    Console.WriteLine(" mas não é par");
                }   
            }
            else
            {
                Console.WriteLine("O numero é menor que 5");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
