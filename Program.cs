using System;
using System.Collections.Generic;

namespace SISTEMA_DE_PRODUTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> ListaProdutos = new List<Produto>();

            while(true)
            {
                
            
                string escolha;

                Console.WriteLine("Deseja Cadastrar ou Listar ?  1 = Cadastrar |  2 = Listar");
                escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Console.WriteLine("Digite o nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto: ");
                    string valor = Console.ReadLine();

                    Console.WriteLine("O produto está em promoção ? Digite Sim ou Não");
                    string promocao = Console.ReadLine();  

                    Cadastrar(nome, valor, promocao, ListaProdutos);

                }
                else if (escolha == "2")
                    {
                        ListarProdutos(ListaProdutos);
                    }
                else
                {
                    Console.WriteLine("Resposta Inválida. Deseja Cadastrar ou Listar ?  1 = Cadastrar |  2 = Listar");
                }
            }

        }

          public class Produto
                {
                   private string nome;
                   private string valor;
                   private string promocao;

                   public string Nome { get => nome; set => nome = value;}
                   public string Valor { get => valor; set => valor = value;}
                   public string Promocao { get => promocao; set => promocao = value;}
               }
           
           static void Cadastrar(string nome, string valor, string promocao,List<Produto> ListaProdutos)
           {
              Produto objeto = new Produto();
              objeto.Nome = nome;
              objeto.Valor = valor;
              objeto.Promocao = promocao;
              ListaProdutos.Add(objeto);
           }


           static void ListarProdutos (List<Produto> ListaProdutos)
           {
                foreach (var Produto in ListaProdutos)
                {
                    Console.WriteLine("[NOME] "+Produto.Nome+" [VALOR] "+Produto.Valor+" [PROMOCAO] "+Produto.Promocao);
                }
           }
    }
}
