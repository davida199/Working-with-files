using System;
using System.IO;
using System.Globalization;
namespace Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\davyd\Desktop\Novo Documento de Texto (2).csv";
            string target = @"C:\Users\davyd\Desktop\out\summary.csv";
            string n1;
            double n2;
            int n3;
            try
            {
                Directory.CreateDirectory(@"C:\Users\davyd\Desktop\out");
                string[] lines = File.ReadAllLines(source);
                foreach (var item in lines)
                {
                    string[] aux = item.Split(',');
                    n1 = aux[0];
                    n2 = double.Parse(aux[1], CultureInfo.InvariantCulture);
                    n3 = int.Parse(aux[2]);
                    Item x = new Item(n1, n2, n3);
                    x.totalValue();
                    using (StreamWriter sw = File.AppendText(target))
                    {
                        sw.WriteLine(x);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorred an error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
/*
Fazer um programa para ler o caminho de um arquivo .csv
contendo os dados de itens vendidos. Cada item possui um
nome, preço unitário e quantidade, separados por vírgula.Você deve gerar um novo arquivo chamado "summary.csv", localizado
em uma subpasta chamada "out" a partir da pasta original do
arquivo de origem, contendo apenas o nome e o valor total para
aquele item (preço unitário multiplicado pela quantidade),
conforme exemplo.

SOURCE FILE
TV LED,1290.99,1
Video Game Chair,350.50,3
Iphone X,900.00,2
Samsung Galaxy 9,850.00,2
 
OUTPUT FILE
TV LED,1290.99
Video Game Chair,1051.50
Iphone X,1800.00
Samsung Galaxy 9,1700.00
 
 */