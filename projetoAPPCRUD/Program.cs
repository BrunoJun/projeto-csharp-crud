using System;
using System.Collections.Generic;

namespace projetoAPPCRUD
{
    class Program
    {

        static CarroRepositorio repositorio = new CarroRepositorio();

        static void Main(string[] args)
        {

            string opcaoUsuario = AparecerMenu();

            while (opcaoUsuario.ToUpper() != "X")
            {
                 
                 switch (opcaoUsuario.ToUpper())
                 {
                     case "1":

                        ListarCarros();
                        break;
                    case "2":

                        InserirCarro();
                        break;
                    case "3":

                        AtualizarCarro();
                        break;
                    case "4":

                        ExcluirCarro();
                        break;
                    case "5":

                        VisualizarCarro();
                        break;
                    case "C":

                        Console.Clear();
                        break;
                     default:

                        throw new ArgumentOutOfRangeException("Opção não disponível.");
                 }

                 opcaoUsuario = AparecerMenu();
            }

            Console.WriteLine("Programa encerrado.");
        }

        private static void ExcluirCarro(){

            Console.WriteLine("Digite o id do carro: ");
            int id = int.Parse(Console.ReadLine());

            repositorio.Excluir(id);
        }

        private static void VisualizarCarro(){

            Console.WriteLine("Digite o id do carro: ");
            int id = int.Parse(Console.ReadLine());

            var carro = repositorio.RetornaPorId(id);

            if (carro != null)
            {
                
                Console.WriteLine(carro);
            }
            else
            {
                
                Console.WriteLine($"ID {id} - Carro excluído do registro.");
            }
        }

        private static void AtualizarCarro()
        {
            Console.WriteLine("Digite o id do carro: ");
            int id = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Marca)))
            {
                
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Marca), i)}");
            }

            Console.WriteLine("Digite a marca entre as opções acima: ");
            int marcaCarro = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o modelo do carro: ");
            string modeloCarro = Console.ReadLine();

            Console.WriteLine("Digite o ano do carro: ");
            int anoCarro = int.Parse(Console.ReadLine());

            Carro novoCarro = new Carro(id, (Marca)marcaCarro, modeloCarro, anoCarro);

            repositorio.Atualizar(id, novoCarro);
        }

        private static void ListarCarros()
        {

            Console.WriteLine("\nLista de carros\n");

            var lista = repositorio.lista();

            if (lista.Count == 0){

                Console.WriteLine("Lista vazia");
                return;
            }

            foreach (var carro in lista)
            {
                if (carro != null)
                {
                   
                   Console.WriteLine($"ID {carro.retornaId()} - {carro.retornaModelo()} - {carro.retornaAno()}");
                }
                else
                {
                    
                    Console.WriteLine("Excluído");
                }
            }
        }

        public static void InserirCarro()
        {

            Console.WriteLine("Inserir novo carro\n");

            foreach (int i in Enum.GetValues(typeof(Marca)))
            {
                
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Marca), i)}");
            }

            Console.WriteLine("Digite a marca entre as opções acima: ");
            int marcaCarro = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o modelo do carro: ");
            string modeloCarro = Console.ReadLine();

            Console.WriteLine("Digite o ano do carro: ");
            int anoCarro = int.Parse(Console.ReadLine());

            Carro novoCarro = new Carro(id: repositorio.ProximoId(), (Marca)marcaCarro, modeloCarro, anoCarro);

            repositorio.Inserir(novoCarro);
        }

        private static string AparecerMenu()
        {

            Console.WriteLine("\nCRUD Carros\n");
            
            Console.WriteLine("1 - Listar carros");
            Console.WriteLine("2 - Inserir novo carro");
            Console.WriteLine("3 - Atualizar carro");
            Console.WriteLine("4 - Excluir carro");
            Console.WriteLine("5 - Visualizar carro");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair\n");

            Console.Write("Informe a opção desejada: ");
            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }
    }
}
