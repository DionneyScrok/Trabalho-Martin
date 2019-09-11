using System;
using System.Globalization;
using System.Collections.Generic;

namespace Trabalho_martin
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continua = true;
            List<Menuzinho> cadastro = new List<Menuzinho>();
            do
            {
                Console.WriteLine("Menu de Cadastro");
                Console.WriteLine("01 - Incluir");
                Console.WriteLine("02 - Aleterar");
                Console.WriteLine("03 - Excluir");
                Console.WriteLine("04 - Listar");
                Console.WriteLine("05 - Pesquisar");
                Console.WriteLine("06 - Sair");
                Console.WriteLine("Digite sua opção: ");
                String opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "01":
                        Console.WriteLine("01 - (INSERIR): ");
                        Console.WriteLine("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nome: ");
                       string nome = Console.ReadLine();
                        Console.WriteLine("Senha: ");
                       string senha = Console.ReadLine();
                        Console.WriteLine("Cadastrado com sucesso!!!");
                        cadastro.Add(new Menuzinho(id, nome, senha));
                        

                        break;
                    case "02":
                        Console.WriteLine("Alterar");
                        Console.WriteLine("Idique o registro a ser alterado (ID): ");
                        int alterarID = int.Parse(Console.ReadLine()); //parei aki
                        Menuzinho men = cadastro.Find(x => x.Id == alterarID);
                        if (men != null)
                        {
                            Console.WriteLine($"ID: {men.Id}");
                            Console.WriteLine($"NOME: {men.Name}");
                            Console.WriteLine($"PASSWORD: {men.Pass}");
                            Console.WriteLine("Digite o que quer alterar: ");
                            string alterar = Console.ReadLine();
                            switch (alterar)
                            {
                                case"id":
                                    Console.WriteLine("Digite o novo id: ");
                                    men.Id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("ID alterado com sucesso!");
                                    break;
                                case "nome":
                                    Console.WriteLine("Digite o novo nome: ");
                                    men.Name = Console.ReadLine();
                                    Console.WriteLine("Nome alterado com sucesso!");
                                    break;
                                case "password":
                                    Console.WriteLine("Digite a nova senha: ");
                                    men.Pass = Console.ReadLine();
                                    Console.WriteLine("Senha alterada com sucesso! ");
                                    break;
                            }



                        }
                        else
                        {
                            Console.WriteLine("Este ID não existe!");
                        }
                        break;
                    case "03":
                        Console.WriteLine("Excluir");
                        Console.WriteLine("Digite o ID que deseja excluir do registro: ");
                        int excID = int.Parse(Console.ReadLine());
                        Menuzinho excluir = cadastro.Find(x => x.Id == excID);
                        if (excID != null)
                        {
                            Console.WriteLine($"ID: {excluir.Id}");
                            Console.WriteLine($"NOME: {excluir.Name}");
                            Console.WriteLine($"PASSWORD: {excluir.Pass}");
                            Console.WriteLine("Deseja realmente excluir o usuario???(Digite s = sim) ou (Digite n = não)");
                            string escolhe = Console.ReadLine();
                            switch (escolhe)
                            {
                                case "s":
                                    cadastro.Remove(excluir);
                                    Console.WriteLine("Usuario removido com sucesso!");
                                    break;
                                case "n":
                                    break;



                            }
                        }
                        else
                        {
                            Console.WriteLine("Este ID não existe!");
                        }


                            break; 
                    case "04":
                        Console.WriteLine("(Listar)");
                        foreach(Menuzinho listar1 in cadastro){
                            Console.WriteLine($"ID: {listar1.Id}");
                            Console.WriteLine($"Nome: {listar1.Name}");
                            Console.WriteLine($"Password: {listar1.Pass}");
                        }

                        break;
                    case "05":
                        Console.WriteLine("(Pesquisar)");
                        Console.WriteLine("Idique o registro a ser alterado (ID): ");
                        int pesquisarID = int.Parse(Console.ReadLine()); //parei aki
                        Menuzinho pesq = cadastro.Find(x => x.Id == pesquisarID);
                        if (pesq != null)
                        {
                            Console.WriteLine($"ID: {pesq.Id}");
                            Console.WriteLine($"NOME: {pesq.Name}");
                            Console.WriteLine($"PASSWORD: {pesq.Pass}");

                        }
                        else
                        {
                            Console.WriteLine("Este ID não existe!");
                        }
                        break;

                        break;
                    case "06":
                        Console.WriteLine("(Sair)");
                        Environment.Exit(06);
                        continua = false;

                        break;
                    default:
                        Console.WriteLine("Opção invalida!!!");
                        break;

                }

            } while (continua);




        }
    }
}
