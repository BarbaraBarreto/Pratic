using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticando
{
    internal class Program
    {
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
     
        static void Main(string[] args)
        {

            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você deseja criar algo?");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("DELETE!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editando");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("O que você deseja listar?");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizando!");
                    break;
                default:
                    Console.WriteLine("Favor selecionar uma das opções acima");
                    break;
            }

            Console.ReadLine();

        }
    }
}
