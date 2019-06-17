using System;
using System.Collections.Generic;

namespace TrabalhoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cliente C = null;
                Carro Car = null;
                Vendas V = null;
                List<Cliente> LC = new List<Cliente>();
                List<Carro> LCar = new List<Carro>();
                List<Vendas> LV1 = new List<Vendas>();
                int OP;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma das opções abaixo: ");
                    Console.WriteLine("1 - Cadastrar cliente");
                    Console.WriteLine("2 - Cadastrar carro");
                    Console.WriteLine("3 - Comprar carro");
                    Console.WriteLine("4 - Lista de vendas");
                    Console.WriteLine("5 - Sair");
                    Console.Write("Digite sua opção: ");
                    OP = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (OP)
                    {
                        case 1:
                            C = new Cliente();
                            Console.Write("Nome: ");
                            C.Nome = Console.ReadLine();
                            Console.Write("CPF: ");
                            C.Cpf = Console.ReadLine();
                            Console.Write("Telefone: ");
                            C.Telefone = Console.ReadLine();
                            Console.Write("E-mail: ");
                            C.Email = Console.ReadLine();
                            Console.Write("Cidade: ");
                            C.Cidade = Console.ReadLine();
                            LC.Add(C);
                            break;

                        case 2:
                            Car = new Carro();
                            Console.Write("Nome do carro: ");
                            Car.Nomecarro = Console.ReadLine();
                            Console.Write("Cor do carro: ");
                            Car.Cor = Console.ReadLine();
                            Console.Write("Nº do chaci: ");
                            Car.Numchaci = Console.ReadLine();
                            Console.Write("Valor do carro: ");
                            Car.Valor = double.Parse(Console.ReadLine());
                            LCar.Add(Car);
                            break;

                        case 3:
                            V = new Vendas();
                            Console.Write("Digite seu nome: ");
                            string n = Console.ReadLine();
                            Console.WriteLine("Digite a data da venda...");
                            Console.Write("Dia: ");
                            int d = int.Parse(Console.ReadLine());
                            Console.Write("Mês: ");
                            int m = int.Parse(Console.ReadLine());
                            Console.Write("Ano: ");
                            int a = int.Parse(Console.ReadLine());
                            V.SetDataVenda(d, m, a);
                            foreach (Cliente itemC in LC)
                            {
                                if (itemC.Nome == n)
                                {
                                    V.Comprador = itemC;
                                    Console.Write("Qual carro você deseja comprar: ");
                                    string nc = Console.ReadLine();
                                    foreach (Carro itemCar in LCar)
                                    {
                                        if (itemCar.Nomecarro == nc)
                                        {
                                            V.AddCarro(itemCar);
                                            Console.WriteLine("Compra realizada com sucesso !!");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            LV1.Add(V);
                            break;
                        case 4:
                            Console.WriteLine("Qual cliente que você deseja verificar as compras feitas?");
                            string cl = Console.ReadLine();
                            foreach (Vendas itemV in LV1)
                            {
                                if (itemV.Comprador.Nome == cl)
                                {
                                    Console.WriteLine(itemV.MostraDados());
                                }
                            }
                            Console.ReadLine();
                            break;

                    }
                } while (OP != 5);

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
