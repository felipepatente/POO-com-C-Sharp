using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras2
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto;

            Compra compra = new Compra();

            do
            {
                Console.WriteLine("\nProdutos");
                Console.WriteLine("1 - Arroz(R$ 9,19)");
                Console.WriteLine("2 - Vinho(R$ 16,39)");
                Console.WriteLine("3 - Maça(R$ 6,60)");
                Console.WriteLine("4 - Carne(R$ 14,96)");
                Console.WriteLine("5 - Pera(R$ 9,80)");
                Console.Write("Entre com o produto ou 0 para finalizar a compra: ");
                produto = Console.ReadLine();
                compra.SetProduto(produto);

                if (produto != "")
                {
                    Console.WriteLine("{0} no carrinho...", compra.GetNomeProduto());
                }

            } while (produto != "");



            Console.WriteLine("Você comprou:");
            Console.WriteLine("Produto        Valor");

            
            for (int i = 0; i < compra.GetProduto().Count; i++)
            {
                Console.WriteLine("{0}            R$ {1}", compra.GetProduto()[i].NomeProduto,
                    compra.GetProduto()[i].Preco);
            }

            Console.WriteLine("Valor a pagar R${0}", compra.GetValorCompra());
        }
    }
}
