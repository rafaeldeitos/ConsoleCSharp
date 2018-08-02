using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int matricula = 10;
            //    string nome = "Rafael";
            //    string sobrenome = "Deitos";
            //    DateTime dataNascimento = DateTime.Now;
            //    decimal salario = 1000.00m;
            //    bool feriasVencidas = true;
            //    char sexo = 'M';



            //    Console.WriteLine(string.Format("{0} {1}", nome, sobrenome));

            int idade = 80;

            //string mensagem = idade > 60 ? "velho" : "jovem";
            string mensagem = "";
            switch (idade)
            {
                case 10:
                    mensagem = "criança";
                    break;
                case 70:
                    mensagem = "adulto";
                    break;
                case 80:
                    mensagem = "muito velho";
                    break;
            }

            Console.WriteLine(mensagem);

            Pessoa p1 = new Pessoa();
            p1.id = 1;
            p1.nome = "teste";

            Console.ReadLine();
        }
    }
}
