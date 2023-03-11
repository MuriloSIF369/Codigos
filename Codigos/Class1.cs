using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigos
{
    public class Aluno
    {
        private string RA;
        public string nome;
        public decimal notaprova;
        public decimal notatrabalho;
        public  decimal notafinal;
        public void Cadastro()
        {
            Console.Write("Digite o nome do Aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite o RA do Aluno: ");
            RA = Console.ReadLine();
            Console.Write("Digite o nota de trabalho do Aluno: ");
            notatrabalho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nota de prova do Aluno: ");
            notaprova = Convert.ToInt32(Console.ReadLine());

            notafinal = notaprova + notatrabalho;
        }
        public void CalcularMedia()
        {
            notafinal = (notatrabalho + notaprova) / 2;
            Console.Write($"Sua média é {notafinal}.");
        }
        public bool CalcularNotaFinal()
        {
 
            decimal media = 14 - notafinal;
            string aviso;
            bool resultado;
            if (notafinal >= 14)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            if (media < 0)
            {
                aviso = "Você passou e não precisa de pontos!";
            }
            else
            {
                aviso = $"Você precisa de {media} pontos para passar!";
            }
            
            Console.Write(aviso);
            return resultado;
        }

    }
}
