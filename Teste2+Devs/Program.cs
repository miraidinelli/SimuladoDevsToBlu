using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2_Devs
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Jogo da Forca
            /*
            int tamanho = 5;
            Random aleatorio = new Random();
            char letra;
            StringBuilder forca = new StringBuilder();

            for(int i = 0; i <= tamanho; i++)
            {
                double temp = aleatorio.NextDouble();
                int alt = Convert.ToInt32(Math.Floor(25 * temp));
                letra = Convert.ToChar(alt + 65);
                forca.Append(letra);
            }
            bool flag = true;

            Console.WriteLine("Vamos Brincar de Forca");
            List<char> erros = new List<char>();
            int chances = 6;
            int acertos = 0;
            while(flag == true)
            {
                Console.WriteLine("Digite uma Letra: ");
                char tentativa = Convert.ToChar(Console.ReadLine().ToUpper());
                if(forca.ToString().Contains(tentativa.ToString()))
                {
                    acertos++;
                    Console.WriteLine("{0} Muito Bom", tentativa);
                    if (acertos == 5)
                    {
                        Console.WriteLine("Você advinhou a palavra: {0}", forca.ToString());
                        flag = false;
                    }
                }
                else
                {
                    chances--;
                    erros.Add(tentativa);
                    if (chances == 0)
                    {
                        Console.WriteLine("Você tem mais {0} chances", chances);
                        Console.WriteLine("Fim de Jogo");
                        flag = false;
                    }
                    else
                    {
                        Console.Write("Você tentou ");
                        foreach(char erro in erros)
                        {
                            Console.Write(erro);
                        }
                        Console.Write(" Até agora.");
                        Console.WriteLine("Você tem mais {0} chances", chances);
                        Console.WriteLine("Tente de Novo");
                    }
                }
            }
            Console.ReadKey();
            */

            //Verifica palindromos
            /*
            Console.WriteLine("Digite uma Palavra: ");
            string palavra = Console.ReadLine();
            palavra = palavra.Replace(" ", "").ToLower();

            bool flag = true;
            for (int i = 0; i < palavra.Length / 2; i++)
            {
                if (palavra[i] != palavra[palavra.Length - i - 1])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("A palavra {0} é um palíndromo.", palavra);
            }
            else
            {
                Console.WriteLine("A palavra {0} não é um palíndromo.", palavra);
            }
            Console.ReadKey();
            */

            int[] numeros = { 5, 8, 3, 54, 75, 23 };
            int tamanho = numeros.Length;

            for (int i = 0; i < -1; i++)
            {
                for (int j = 0; j < tamanho - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        var temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }
        }
    }
}
