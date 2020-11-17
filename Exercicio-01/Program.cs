using System;

namespace Exercicio_01
{
    class Program
    {
        enum Products{Pastel, Coxinha, Hamburgao, Guarana};
        static void Main(string[] args)
        {
            int id, amount;
            id=amount=0;
            double purchaseValue, valueSale, profit;
            purchaseValue=valueSale=profit=0;

            Console.WriteLine("--> Produtos disponíveis:");
            Console.WriteLine("1 - " + Products.Coxinha);
            Console.WriteLine("2 - " + Products.Pastel);
            Console.WriteLine("3 - " + Products.Hamburgao);
            Console.WriteLine("4 - " + Products.Guarana);

            Console.Write("--> Digite o Cod. Do Produto : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("--> Digite a quantidade : ");
            amount = Int16.Parse(Console.ReadLine());

            if (id == 1)
            {
                purchaseValue = 4.50;
                profit = 0.2;
                Products product= Products.Coxinha;
                valueSale = amount * (purchaseValue + (purchaseValue*profit));

                Console.WriteLine("Produto......:{0, 15}", product);
                Console.WriteLine("Val.Compra...:{0, 15:c}", purchaseValue);
                Console.WriteLine("Lucro........:{0, 15:p}", profit);
                Console.WriteLine("Val.Venda....:{0, 15:c}", valueSale);
            } else if (id == 2) 
            {
                purchaseValue = 4.50;
                profit = 0.3;
                Products product= Products.Pastel;
                valueSale = amount * (purchaseValue + (purchaseValue*profit));

                Console.WriteLine("Produto......:{0, 15}", product);
                Console.WriteLine("Val.Compra...:{0, 15:c}", purchaseValue);
                Console.WriteLine("Lucro........:{0, 15:p}", profit);
                Console.WriteLine("Val.Venda....:{0, 15:c}", valueSale);
            } else if (id == 3) 
            {
                purchaseValue = 5.00;
                profit = 0.2;
                Products product= Products.Hamburgao;
                valueSale = amount * (purchaseValue + (purchaseValue*profit));

                Console.WriteLine("Produto......:{0, 15}", product);
                Console.WriteLine("Val.Compra...:{0, 15:c}", purchaseValue);
                Console.WriteLine("Lucro........:{0, 15:p}", profit);
                Console.WriteLine("Val.Venda....:{0, 15:c}", valueSale);
            } else if (id == 4) 
            {
                purchaseValue = 2.50;
                profit = 0.4;
                Products product= Products.Guarana;
                valueSale = amount * (purchaseValue + (purchaseValue*profit));

                Console.WriteLine("Produto......:{0, 15}", product);
                Console.WriteLine("Val.Compra...:{0, 15:c}", purchaseValue);
                Console.WriteLine("Lucro........:{0, 15:p}", profit);
                Console.WriteLine("Val.Venda....:{0, 15:c}", valueSale);
            } else
            {
                Console.Write("Alerta: id não existente!!");
            }
        } 
    }
}
